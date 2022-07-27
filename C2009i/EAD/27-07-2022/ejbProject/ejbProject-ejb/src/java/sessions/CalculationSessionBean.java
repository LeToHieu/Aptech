/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sessions;

import javax.ejb.Stateless;

@Stateless
public class CalculationSessionBean implements CalculationSessionBeanLocal {
    @Override
    public int sum(int x, int y) {
        return x + y;
    }
}
