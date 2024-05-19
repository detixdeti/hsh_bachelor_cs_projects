<%-- 
    Document   : bmi_start
    Created on : 09.05.2022, 19:38:35
    Author     : uni
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <title> BMI Rechner JSP </title>
    <body>
            <form action ="bmi_result.jsp" method="post">
            BMI Rechner: <br/>

            Koerpergroesse: <input type="number" name="cm" placeholder="in cm" min="100" max="300" required/> <br/>
            Koerpergewicht: <input type="number" name="kg" placeholder="in kg" min="30" max="300" required /> <br/> 

            <input type="submit" value="Berechne" />
        </form>
    </body>
</html>

