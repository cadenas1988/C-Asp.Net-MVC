$.get("RepasoHTML/llenaComboPersona", function (data) {
    //alert(JSON.stringify(data));
    var contenido = "";
    var nregistros = data.length;
    for (var i = 0; i < nregistros; i++) {

        contenido += "<option values=' " + data[i].idPersona + " ' >";

        contenido+= data[i].nombre

        contenido += "</option>";
    }

    document.getElementById("cboPersona").innerHTML = contenido;
});