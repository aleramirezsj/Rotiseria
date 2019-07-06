$(document).ready(
    function () {
        $("#PrecioCompra").bind("change", calcularTotal);
        $("#Cantidad").bind("change", calcularTotal);
        $("#ProductoId").bind("change", obtenerPrecioProducto);
        //$("#txtCadenaBusquedaLocalidades").bind("keyup", refrescarTablaLocalidades);
        //$("#txtCadenaBusquedaUsuarios").bind("keyup", refrescarTablaUsuarios);

    }
);

function calcularTotal() {
    if ($("#PrecioCompra").length > 0) {
        var precio = $("#PrecioCompra").val();
        var cantidad = $("#Cantidad").val();
        $("#Total").val(precio * cantidad);
    } else {
        var precio = $("#PrecioVenta").val();
        var cantidad = $("#Cantidad").val();
        $("#Total").val(precio * cantidad);
    }
}

function obtenerPrecioProducto() {
    precioProducto = 0;
    idProductoSeleccionado = $("#ProductoId").val();
    var promise = $.ajax({
        url: "/api/ProductoesAPI/" + idProductoSeleccionado,
        data: "",
        type: "GET",
        success: function (datos) {
            precioProducto = datos.PrecioVenta;
            costoProducto = datos.PrecioCosto;
        }
    })
    promise.then(function () {
        $("#PrecioCompra").val(costoProducto);
        $("#PrecioVenta").val(precioProducto);
        calcularTotal();
    })
}