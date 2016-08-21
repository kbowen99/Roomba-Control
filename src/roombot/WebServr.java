package roombot;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpServer;

/**
 * Extremely Messy/bad java webserver, Mostly POC but it works
 * TODO: Cleanup/Rewrite
 * @author Kurtis Bowen (Kbowen99)
 */
public class WebServr {
	private static String ipAddr = Main.ipAddr; //Get IP from Main
	
	public WebServr(int port) throws Exception{
		//Create & Bind Server to Specified Port
        HttpServer server = HttpServer.create(new InetSocketAddress(port), 0);
        //Create all Routes
        server.createContext("/", new Home());
        server.createContext("/w", new Forward());
        server.createContext("/a", new Leftward());
        server.createContext("/s", new Backward());
        server.createContext("/d", new Rightward());
        server.createContext("/q", new Brake());
        server.setExecutor(null); // creates a default executor
        //Start Server with Routes
        server.start();
	}
	
	//Begin Mess
	
	//"Home" Page (Root) - Just gives help
	static class Home implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = "Welcome to Roomba Control! \n"
            		+ "To get started use the following:\n"
            		+ ipAddr + "/w - Move Forward\n"
            		+ ipAddr + "/a - Rotate Left\n"
            		+ ipAddr + "/s - Move Backward\n"
            		+ ipAddr + "/d - Rotate Right\n"
            		+ ipAddr + "/q - Stop Move\n";
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
    
	//Forward - Sends 'w' over SerialControl
    static class Forward implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = Main.p("Moving Forward!").toString();
            Main.s.send("w");
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
    
    //Backward - Sends 's' over SerialControl
    static class Backward implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = Main.p("Moving Backwards!").toString();
            Main.s.send("s");
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
    
    //Leftward - Sends 'a' over SerialControl
    static class Leftward implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = Main.p("Rotating Left!").toString();
            Main.s.send("a");
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
    
    //RightWard - Sends 'd' over SerialControl
    static class Rightward implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = Main.p("Rotating Right!").toString();
            Main.s.send("d");
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
    
    //Brake - Sends Stop Command '.' over SerialControl
    static class Brake implements HttpHandler {
        @Override
        public void handle(HttpExchange t) throws IOException {
            String response = Main.p("Stopping").toString();
            Main.s.send(".");
            t.sendResponseHeaders(200, response.length());
            OutputStream os = t.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    }
}
