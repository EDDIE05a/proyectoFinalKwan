<div class="container1">
    <div class="contactar">
        <h3>Contáctenos</h3>
    </div>

    <div class="contactar2">
        <p>En Kwan Academy, dedicamos a brindarle a nuestros estudiantes la mejor experiencia de entrenamiento de defensa personal. Si tienes alguna pregunta acerca de nuestros cursos, no dudes en contactarnos. Nuestro equipo se comunicará con usted lo antes posible.</p>
    </div>

    <div class="mensaje">
        <form asp-action="crear" method="post">
            <div class="form-group">
                <label for="Nombre">Nombre</label>
                <input class="form-control" id="Nombre" placeholder="Ingrese el nombre">
            </div>

            <div class="form-group">
                <label for="Telefono">Teléfono</label>
                <input class="form-control" id="Telefono" placeholder="Ingrese el teléfono">
            </div>

            <div class="form-group">
                <label for="Email">Email</label>
                <input class="form-control" id="Email" placeholder="Ingrese el email">
            </div>

            <div class="form-group">
                <label for="Mensaje">Mensaje</label>
                <asp:textarea class="form-control" id="Mensaje" placeholder="Escribir mensaje">
            </div>

            <div class="btnMensaje">
                <button type="submit" class="btn btn-primary mt-3">Enviar mensaje</button>
            </div>

        </form>
        
    </div>

</div>