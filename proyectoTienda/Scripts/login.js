
    $(document).ready(function () {
        
        $("#loginLink").click(function (ev) {

         
            ev.preventDefault();
           
            $(".contenedor_modal").toggle();
        })

        $(".modal-backdrop").click(function () {

            alert("hola")
        })

    })

