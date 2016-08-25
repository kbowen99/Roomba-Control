package roombot;

import java.net.InetAddress;

/**
 * Main class is used to construct & pass information between Webserver & Serial Port
 * @author Kurtis Bowen (Kbowen99)
 */
public class Main {
	static String ipAddr; //Local IP Address, put in main for future expansion
	//static SerialControl s; //Serial Control, is accessed by Webserver
	//static WebServr w; //Webserver (Its an ugly mess)
	
	@SuppressWarnings("unused")
	public static void main(String[] args) throws Exception {	
		ipAddr = InetAddress.getLocalHost().getHostAddress().toString(); //Get Local
		SerialControl s = new SerialControl("COM3", 9600); //"COM3" should be found automatically... TODO: Find Serial Port to use
		WebServr w = new WebServr(80, s); //Start Webserver on Port 80
	}
	/**
	 * Lazy Debugging, Should probably be moved...
	 * @param O - Object to Print
	 * @return O - Printed Object
	 */
	public static Object p(Object O){
		System.out.println(O); return O;
	}
}
