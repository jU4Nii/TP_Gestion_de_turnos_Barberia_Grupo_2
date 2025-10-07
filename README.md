# TP_Gestion_de_turnos_Barber-a_Grupo_2

Es un sistema pensado para ayudar a las barberías a organizar sus turnos de atención.
Permite registrar, modificar y eliminar turnos de forma simple, asignando a cada uno un cliente, un peluquero, una fecha, hora y servicio.
El objetivo principal es evitar confusiones o superposiciones de horarios y mejorar la organización diaria del negocio.

Funcionalidades importantes previstas:
Registrar un nuevo turno con cliente, peluquero, fecha, hora y servicio.
Modificar o cancelar turnos existentes.

Reportes:
Listado diario de turnos.
Listado de turnos por peluquero.

[Diagrama de clases](https://drive.google.com/file/d/180hblzCkvmoJaHgWcpC75ZA0nvHy6UlH/view?usp=sharing)

Capas:
Presentación: interfaz donde el usuario carga y consulta los turnos.
Negocio: maneja las validaciones, como evitar turnos duplicados o con horarios cruzados.
Datos: guarda los turnos en la base de datos o archivo correspondiente.
