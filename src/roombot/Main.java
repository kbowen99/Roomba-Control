package roombot;

import java.net.InetAddress;

/**
 * Main class is used to construct & pass information between Webserver & Serial Port
 * @author Kurtis
 */
public class Main {
	static String ipAddr;
	static SerialControl s;
	static WebServr w;
	
	public static void main(String[] args) throws Exception {	
		ipAddr = InetAddress.getLocalHost().getHostAddress().toString();
		s = new SerialControl("COM3", 9600);
		w = new WebServr(80);
	}
	
	public static Object p(Object O){
		System.out.println(O); return O;
	}
}
