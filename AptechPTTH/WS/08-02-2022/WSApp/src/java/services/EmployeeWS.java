/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package services;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.persistence.*;
import models.Employee;

/**
 *
 * @author sunli
 */
@WebService(serviceName = "EmployeeWS")
public class EmployeeWS {
    //@PersistenceContext(unitName = "WSAppPU")
    private EntityManager entityManager = Persistence.createEntityManagerFactory("WSAppPU")
                .createEntityManager();
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {        
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "findAll")
    public HashMap<String, Object> findAll() {
        HashMap<String, Object> result = new HashMap<>();
        try {
            Query query = entityManager.createNamedQuery("Employee.findAll", Employee.class);
            java.util.List<Employee> employees = query.getResultList();
            result.put("result", "ok");
            result.put("data", employees);        
            result.put("message", "Query employees successfully");        
        } catch(Exception e) {
            result.put("result", "failed");
            result.put("data", new ArrayList<>());        
            result.put("message", "Query employees failed");        
        }
        return result;
    }
    /*
    @WebMethod(operationName = "insertEmployee")
    public HashMap<String, Object> insertEmployee(
            @WebParam(name = "employeeNo") String employeeNo,
            @WebParam(name = "employeeName") String employeeName,
            @WebParam(name = "placeOfWork") String placeOfWork,
            @WebParam(name = "phoneNo") String phoneNo) {
        HashMap<String, Object> result = new HashMap<>();
        try {
            Employee newEmployee = new Employee(employeeNo, employeeName, placeOfWork, phoneNo);
            entityManager.persist(newEmployee);
            entityManager.getTransaction().commit();
            result.put("result", "ok");
            result.put("data", newEmployee);        
            result.put("message", "Insert employee successfully");        
        } catch(Exception e) {
            result.put("result", "failed");
            result.put("data", new ArrayList<>());        
            result.put("message", "Insert employee failed");        
        }
        return result;
    }
    @WebMethod(operationName = "updateEmployee")
    public HashMap<String, Object> updateEmployee(
            @WebParam(name = "employeeNo") String employeeNo,
            @WebParam(name = "employeeName") String employeeName,
            @WebParam(name = "placeOfWork") String placeOfWork,
            @WebParam(name = "phoneNo") String phoneNo) {
        HashMap<String, Object> result = new HashMap<>();
        try {
            Query query = entityManager.createNamedQuery("Employee.findByEmployeeNo", Employee.class);
            query.setParameter(1, employeeNo);
            Employee employee = (Employee) query.getSingleResult();
            if(employee != null) {
                employee.setEmployeeName(employeeName != null ? employeeName : employee.getEmployeeName());
                employee.setPlaceOfWork(placeOfWork != null ? placeOfWork : employee.getPlaceOfWork());
                employee.setPhoneNo(phoneNo != null ? phoneNo : employee.getPhoneNo());                
            }                        
            entityManager.persist(employee);
            entityManager.getTransaction().commit();
            result.put("result", "ok");
            result.put("data", employee);        
            result.put("message", "Update employee successfully");        
        } catch(Exception e) {
            result.put("result", "failed");
            result.put("data", new ArrayList<>());        
            result.put("message", "Update employee failed");        
        }
        return result;
    }
    @WebMethod(operationName = "deleteEmployee")
    public HashMap<String, Object> deleteEmployee(
            @WebParam(name = "employeeNo") String employeeNo) {
        HashMap<String, Object> result = new HashMap<>();
        try {
            Query query = entityManager.createNamedQuery("Employee.findByEmployeeNo", Employee.class);
            query.setParameter(1, employeeNo);
            Employee employee = (Employee) query.getSingleResult();            
            if(employee != null) {
                entityManager.remove(employee);
            }                        
            entityManager.persist(employee);
            entityManager.getTransaction().commit();
            result.put("result", "ok");
            result.put("data", employee);        
            result.put("message", "Delete employee successfully");        
        } catch(Exception e) {
            result.put("result", "failed");
            result.put("data", new ArrayList<>());        
            result.put("message", "Delete employee failed");        
        }
        return result;
    }
*/
}
  