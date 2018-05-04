<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestApp.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link href="css/task.css" rel="stylesheet" />
</head>
<body>

    <div class="container">
        <h3>Tooltip Example</h3>
        <%--<a href="#" data-toggle="tooltip" title="Hooray!">Hover over me</a>--%>
        <a href="#" data-toggle="tooltip" title="Tooltip on top">
            <span class="glyphicon glyphicon-plus"></span>
        </a>
    </div>
    <%--<script src="js/jquery.min.js"></script>--%>
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/task.ui.js"></script>
    <%-- <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>--%>
</body>
</html>

