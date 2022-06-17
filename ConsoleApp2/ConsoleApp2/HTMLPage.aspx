<!DOCTYPE html>

<html>
<head>
    <title> Change to Upper Case </title>
</head>

<body>
    <h3> Conversion to Upper Case </h3>

    <form runat="server">
        <input runat="server" id="mytext" type="text" />
        <input runat="server" id="button1" type="submit" value="Enter..." OnServerClick="convertoupper" />

        <hr />
        <h3> Results: </h3>
        <span runat="server" id="changed_text" />
    </form>

</body>

</html>


