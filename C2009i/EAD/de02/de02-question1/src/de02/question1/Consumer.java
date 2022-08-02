/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package de02.question1;
import javax.jms.JMSException;
import javax.jms.MapMessage;
import javax.jms.Message;
import javax.jms.MessageListener;
import javax.jms.TextMessage;
/*
Find jar lib of activemq-all-5.12.2.jar
*/
public class Consumer implements MessageListener {
    private String consumerName;
    public Consumer(String consumerName) {
        this.consumerName = consumerName;
    }
 
    public void onMessage(Message message) {
        if (message instanceof TextMessage) {
            TextMessage textMessage = (TextMessage) message;
            try {
                System.out.println("Received " + textMessage.getText());
            } catch (JMSException e) {          
                e.printStackTrace();
            }
	}
	else if (message instanceof MapMessage) {
            MapMessage mapMessage = (MapMessage)message;
            System.out.println("Received " + mapMessage.toString());
            
	}
        
        
    }
 
}
