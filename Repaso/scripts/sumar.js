var btnSumar = document.getElementById("btnSumar");

btnSumar.onclick = function () {
    var numero1 = document.getElementById("txtnumero1").value *1;
    var numero2 = document.getElementById("txtnumero2").value *1;
    var suma = numero1 + numero2;

    document.getElementById("lblRespuesta").innerHTML="La suma " +suma;
}

var btnLimpiar = document.getElementById("btnLimpiar");

btnLimpiar.onclick = function () {
    document.getElementById("txtnumero1").value = "";
    document.getElementById("txtnumero2").value = "";
    document.getElementById("lblRespuesta").innerHTML="";

}