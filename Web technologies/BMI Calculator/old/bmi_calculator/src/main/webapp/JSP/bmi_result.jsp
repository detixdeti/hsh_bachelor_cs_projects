<%-- 
    Document   : bmi_result
    Created on : 09.05.2022, 19:38:58
    Author     : uni
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head> <title> Zeige Namen an </title> </head>
    <body>
        <%
            int kg = Integer.parseInt(request.getParameter("kg"));
            int cm = Integer.parseInt(request.getParameter("cm"));
                  
            double bmi = (double)kg/( ((double)cm/100)*((double)cm/100) );
            bmi = Math.round(bmi * 100.0)/100.0;
        %>
        Ihr BMI ist: <%=bmi%> 
    </body>
</html>


