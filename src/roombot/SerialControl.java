package roombot;

import java.io.OutputStream;
import java.util.Enumeration;

import gnu.io.CommPortIdentifier;
import gnu.io.SerialPort;

public class SerialControl {
	
    static Enumeration<?> portList;
    static CommPortIdentifier portId;
    static String messageString = "";
    static SerialPort serialPort;
    static OutputStream outputStream;
    
    int speed;
    
	public SerialControl(String COM, int speed){
		this.speed = speed;
		portList = CommPortIdentifier.getPortIdentifiers();
        while (portList.hasMoreElements()) {
            portId = (CommPortIdentifier) portList.nextElement();
            if (portId.getPortType() == CommPortIdentifier.PORT_SERIAL) {
                 if (portId.getName().equals(COM)) {
                	 try{
                	 	serialPort = (SerialPort)portId.open("SerialControl", 2000);
                        outputStream = serialPort.getOutputStream();
                        serialPort.setSerialPortParams(speed,
                        		SerialPort.DATABITS_8,
                        		SerialPort.STOPBITS_1,
                        		SerialPort.PARITY_NONE);
                        outputStream.write(messageString.getBytes());
                        break;
                	 } catch (Exception e){}
                 }
            }
        }
	}
	
	public void send(String toSend){
		Main.p("Attempting to send: " + toSend);
		try{
        outputStream = serialPort.getOutputStream();
        serialPort.setSerialPortParams(speed,
        		SerialPort.DATABITS_8,
        		SerialPort.STOPBITS_1,
        		SerialPort.PARITY_NONE);
        outputStream.write(toSend.getBytes());
		} catch (Exception e) {
			Main.p("Shit Happened....");
			e.printStackTrace();
		}
	}
}
