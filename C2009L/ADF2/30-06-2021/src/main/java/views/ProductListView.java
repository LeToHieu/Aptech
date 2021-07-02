package views;

import models.Person;
import utilities.DateUtility;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.Date;

public class ProductListView implements IView{
    //Khai niem "state" trong Screen
    //Bai tap buoi sau: du lieu thay doi (1giay thay doi 1 lan) => man hinh ProductList view thay doi theo
    //Hien man hinh tiep theo nhung man Login phai bien mat
    private JFrame mainFrame = new JFrame();
    private int width, height;
    private ArrayList<Person> persons = new ArrayList<>();
    private Object[][] mapPersonsToData() {
        Object[][] result = new String[persons.size()][];
        try {
            for(int row = 0; row < persons.size(); row++) {
                result[row] = new String[]{
                        persons.get(row).getRollNumber(),
                        persons.get(row).getName(),
                        DateUtility.convertDateToString(persons.get(row).getDateOfBirth())
                };
            }
        }catch (Exception e) {
            System.err.println("hahja");
        }
        return result;
    }
    private void setupFakeData() {
        //fake chi de test UI
        //sau nay du lieu phai lay tu DB
        persons.add(new Person("John", "a1233", "06/27/1993"));
        persons.add(new Person("Anna", "x2332", "07/25/2000"));
        persons.add(new Person("Nguyen Duc Hoang", "c3343", "12/27/2001"));
    }
    public ProductListView(int width, int height) {
        this.width = width;
        this.height = height;
    }
    public void reloadData() {
        setupFakeData();
        setupUI(width, height);
    }
    //de them Retype password(can public Gridlayout), can sua tieu de(public JFrame)
    @Override
    public void setupUI(int width, int height) {
        //fake data
        JTable table = new JTable(
                this.mapPersonsToData(),
                new String[] {"Roll number", "Name", "Date of birth"});

        JScrollPane scrollPane = new JScrollPane(table);
        // Cho phep table sap xep
        table.setAutoCreateRowSorter(true);
        mainFrame.add(scrollPane, BorderLayout.CENTER);
        mainFrame.setSize(width, height);
        mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        mainFrame.setLocationRelativeTo(null);
    }

    @Override
    public void show() {
        mainFrame.setVisible(true);
    }

    @Override
    public void hide() {
       mainFrame.setVisible(false);
    }
}
