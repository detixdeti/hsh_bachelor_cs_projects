/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author uni
 */
@WebServlet(name = "BMI", urlPatterns = {"/calculator"})
public class bmi_calculator extends HttpServlet {

  @Override
  public void service(HttpServletRequest req, HttpServletResponse resp)
                                    throws ServletException, IOException{
    int cm = Integer.parseInt(req.getParameter("cm"));
    int kg = Integer.parseInt(req.getParameter("kg"));
    
    double bmi = (double)kg/( ((double)cm/100)*((double)cm/100) );
    
    PrintWriter out = resp.getWriter();
    out.println("<html>");
    out.println(" <head><title>BMI Rechner</title></head>");
    out.println(" <body>");
    out.println("   Dein BMI ist " + Math.round(bmi * 100.0)/100.0 + "! <br>");
    out.println(" </body>");
    out.println("</html>");
  }
}
