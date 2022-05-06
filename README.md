![imagen](https://user-images.githubusercontent.com/78119165/160845077-e97f5cda-6dbb-476a-8dfa-8a8420b9d798.png)

<h1 align="center">Primer parcial de Laboratorio 2 UTN - Mayo de 2022</h1>

# **El codigo que esta en este repo fue escrito con ❤ amor y dedicacion. Dare mighty things!**

---

⭐️ La aplicacion gestiona las ventas en un bar en sus 15 mesas y 5 barras. Muestra los lugares disponibles del bar en color verde y los lugares ocupados en color rojo. Segun si la persona que se loguea es un administrador o un vendedor, el color de fondo del formulario es diferente.

⭐️ El formulario de login cuenta con un boton para restablecimiento de la contraseña, y dos botones para ingreso de datos precargados.

⭐️ Desde el formulario de venta, ademas de realizar las ventas en las mesas y barras, se puede ver quien es el usuario logueado, revisar el stock de productos y buscar mesas y barras libres.

⭐️ El administrador tiene botones extra para ver la lista de empleados, agregar mercaderia al stock y ver la facturacion del dia.

⭐️ El ticket de compra agrega un porcentaje por el pago con tarjeta, suma el valor del estacionamiento (si correspondiera) y aplica descuentos.

⭐️ El boton que "imprime" el ticket en realidad lo guarda en un archivo txt en el escritorio.

✅ La clase Vendedor y la clase Administrador ambas heredan de Persona, con lo cual se utiliza herencia.

✅ Persona es la encargada de validar la contraseña, el formulario de login nunca accede a ese dato.

✅ Se utiliza sobrecarga de constructores en la clase Producto, ya que el requisito minimo para instanciar un producto es su nombre, si es o no una bebida y su precio, pero tambien pueden crearse productos con los demas atributos de la clase.

✅ Sobrecarga de metodos se utiliza en la clase Bar para agregar un producto al stock utilizando un producto como tal, o sus atributos por separado.

✅ Se sobrecarga el operador == en la clase Producto para que compare por el nombre de producto.

✅ Propiedades: se usan para encapsulamiento de los atributos de las clases, y que las demas entidades que deban usarlos los reciban solo a traves de ellas.

✅ Colecciones: hay una List de puestos de venta y un Dictionary con los productos en stock, para aprovechar la funcionalidad de almacenar juntos una clave y un valor.

✅ Se utiliza un enumerado para cargar el combo box desplegable de productos al hacer una venta.

✅ Formularios modales, se utilizan varios, por ejemplo para mostrar el stock y el listado de empleados.

✅ Hay una clase estatica (la clase Bar no se instancia).

✅ Hay una clase abstracta (la clase Persona no acepta la creacion de personas sino de sus derivadas).

✅ Metodo abstracto DescontarPromo, en la clase Persona, obliga a sus derivadas a implementar como sea necesario. La clase admin realiza un descuento del 20 % mientras la clase Vendedor solo puede aplicar descuentos del 10%. Cuando se aplica un descuento, este varia segun quien lo aplica.

✅ Metodo virtual DescontarHappyHour, en la clase Persona, para que cada clase derivada implemente el metodo o lo cambie si lo considera correcto

✅ Se utilizan dos sonidos diferentes, un beep corto y un beep largo, el primero cuando se cargan los formularios y el segundo al realizar algunas acciones, dentro de un bloque try catch por si hubiera alguna excepcion al utilizar los archivos de sonido.
