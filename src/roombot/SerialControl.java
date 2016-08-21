package roombot;

import java.io.OutputStream;
import java.util.Enumeration;

import gnu.io.CommPortIdentifier;
import gnu.io.SerialPort;

/**
 * Serial Control Class using RXTX Library, tries to keep Serial port Open
 * TODO: Implement Closing of serial port
 * @author Kurtis Bowen (Kbowen99)
 */
public class SerialControl {
	
    static Enumeration<?> portList;
    static CommPortIdentifier portId;
    static SerialPort serialPort;
    static OutputStream outputStream;
    
    int speed;
    
    /**
     * "Finds" Specified Control Port, Opens it, and "Starts" it
     * @param COM - Port To Be Used
     * @param speed - Communication Speed
     */
	public SerialControl(String COM, int speed){
		this.speed = speed;
		portList = CommPortIdentifier.getPortIdentifiers(); //Create a list of all *Possible* Serial Ports
        while (portList.hasMoreElements()) {
            portId = (CommPortIdentifier) portList.nextElement(); //Cycles through list
            if (portId.getPortType() == CommPortIdentifier.PORT_SERIAL) { //if we find the type & Name wanted, try and open it
                 if (portId.getName().equals(COM)) {
                	 try{
                	 	serialPort = (SerialPort)portId.open("SerialControl", 2000);
                        outputStream = serialPort.getOutputStream();
                        serialPort.setSerialPortParams(speed,
                        		SerialPort.DATABITS_8,
                        		SerialPort.STOPBITS_1,
                        		SerialPort.PARITY_NONE);
                        outputStream.write("".getBytes());
                        break; //If it makes it this far, we know this is the port we wanted
                        //infinite loop may occur... TODO: Add Sentinel for Port Search...
                	 } catch (Exception e){} //if port failed, continue searching (Will probably end up checking same port several times...
                 }
            }
        }
	}
	
	/**
	 * Sends a String to an initialized SerialControl (Opened & Setup Serial Port)
	 * @param toSend - String To Send
	 */
	public void send(String toSend){
		Main.p("Attempting to send: " + toSend); 
		try{ //Notice How Port.Open() isn't needed? Thats Important for an arduino
			outputStream = serialPort.getOutputStream();
			serialPort.setSerialPortParams(speed, //Most of this isn't needed... TODO: Clean Up SerialConnect.send()
					SerialPort.DATABITS_8,
					SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
			outputStream.write(toSend.getBytes());
		} catch (Exception e) { //Hopefully we never get to this point...
			Main.p("Stuff Happened....");
			e.printStackTrace();
		}
	}
}
