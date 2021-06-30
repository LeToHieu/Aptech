package views;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LoginView {
    //thuoc tinh: TextField email TextField Password
    final JFrame mainFrame = new JFrame("Login view");
    final JTextField textFieldEmail = new JTextField(6);
    final JPasswordField textFieldPassword = new JPasswordField(6);
    final JButton buttonLogin = new JButton("Login to your account");

    public void setupUI() {
        mainFrame.setResizable(false);
        final GridLayout gridLayout = new GridLayout(3, 2);
        gridLayout.setHgap(10);
        gridLayout.setVgap(10);
        mainFrame.setLayout(gridLayout);

        mainFrame.add(new JLabel("Email :"));
        mainFrame.add(textFieldEmail);
        mainFrame.add(new JLabel("Password :"));
        mainFrame.add(textFieldPassword);
        mainFrame.add(buttonLogin);
        buttonLogin.addActionListener((ActionEvent event) -> {
            System.out.println(String.format("Email = %s, password = %s", textFieldEmail.getText(), textFieldPassword.getPassword()));
        });

    }
    public LoginView(int width, int height){
        mainFrame.setSize(width, height);
        setupUI();
    }
    public void show() {
        //mot so viec khac
        mainFrame.setVisible(true);
    }
    public void hide() {
        mainFrame.setVisible(false);
    }

}
