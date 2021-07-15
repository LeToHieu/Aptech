<html>
<body>
<head>
    <%@page import="org.example.Person"%>
</head>    
<h1>chao ban</h1>    
<h2>This is index</h2>
<div>
    <%= 10*5%>
    <%

    for(int i = 0;  i < 10; i++) {
        out.println(String.format("<p>i = %d</p>", i));
    }    
    %>
    <%!
    int sum2Numbers(int x, int y) {
        return x + y;
    }
    %>
    <h2>Do something</h2>
    <%
        int z = sum2Numbers(1, 2);
        out.println("z11 = "+z);
        Person mrA = new Person(1, "Hoang");
        out.println("name = "+mrA.getName());
    %>
    
</div>
</body>
</html>
