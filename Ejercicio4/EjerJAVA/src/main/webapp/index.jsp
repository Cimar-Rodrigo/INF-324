<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<a href="MyServlet">GET</a>
	
	<%
		String apiData = (String) request.getAttribute("apiData");
		out.println("Datos de la API: " + apiData );
		
	%>
	
	<br>
	<br>
	<%
		out.println("\nMostrando datos de la cuenta");
		
		String apiData2 = (String) request.getAttribute("apiData2");
		out.println("Datos de la API: " + apiData2 );
	
	%>		
</body>
</html>