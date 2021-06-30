package views;
import org.w3c.dom.xpath.XPathNamespace;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LoginView implements IView{
    //thuoc tinh: TextField email TextField Password
    private final JFrame mainFrame = new JFrame("Login view");
    private final JTextField textFieldEmail = new JTextField(6);
    private final JPasswordField textFieldPassword = new JPasswordField(6);
    private final JButton buttonLogin = new JButton("Login");
    private final GridLayout gridLayout = new GridLayout(3,2);

    public JFrame getMainFrame() {
        return mainFrame;
    }
    public GridLayout getGridLayout() {
        return gridLayout;
    }
    @Override
    public void setupUI(int width, int height) {
        mainFrame.setSize(width, height);
        JPanel innerView = new JPanel(gridLayout);
        innerView.setBorder(new EmptyBorder(20, 20, 20, 20));

        innerView.add(new JLabel("Email :"));
        innerView.add(textFieldEmail);
        innerView.add(new JLabel("Password :"));
        innerView.add(textFieldPassword);
        innerView.add(buttonLogin);

        buttonLogin.addActionListener((ActionEvent event) -> {
            System.out.println(String.format("Email = %s, password = %s", textFieldEmail.getText(), textFieldPassword.getPassword()));
        });
        mainFrame.add(innerView);
    }

    public LoginView(int width, int height){
        //mainFrame.setSize(width, height);
        setupUI(width, height);
    }
    @Override
    public void show() {
        //mot so viec khac
        Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
        mainFrame.setLocation(dim.width/2-mainFrame.getSize().width/2, dim.height/2-mainFrame.getSize().height/2);
        mainFrame.setVisible(true);
    }
    @Override
    public void hide() {
        mainFrame.setVisible(false);
    }
}
