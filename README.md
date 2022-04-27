![descarga](https://user-images.githubusercontent.com/78119165/160845077-e97f5cda-6dbb-476a-8dfa-8a8420b9d798.png)

Primer parcial de Laboratorio 2 UTN - 2022

El codigo que esta en este repo fue escrito con amor y dedicacion. Dare mighty things!

Se utilizan formularios que tienen dos colores diferentes segun ingrese un vendedor o un admin.
El login cuenta con un boton para restablecimiento de la contraseña si el usuario la olvida, y dos botones para ingreso de datos rapidamente.
La clase Vendedor y la clase Administrador ambas heredan de Persona, con lo cual se utiliza herencia.
Se utiliza sobrecarga de constructores en la clase Producto, ya que el requisito minimo para instanciar un producto es su nombre, si es o no una bebida y su precio, pero tambien pueden crearse productos con los demas atributos de la clase.
Sobrecarga de metodos se utiliza en la clase Bar para agregar un producto al stock utilizando un producto como tal, o sus atributos por separado.
Propiedades: se usan para encapsulamiento de los atributos de las clases, y que las demas entidades que deban usarlos los reciban solo a traves de ellas.
Colecciones: hay una List de puestos de venta y un Dictionary con los productos en stock, para aprovechar la funcionalidad de almacenar juntos una clave y un valor.
Enumerados
Formularios modales, se utilizan varios, por ejemplo para mostrar el stock y el listado de empleados.
Hay una clase estatica (la clase Bar no se instancia).
Hay una clase abstracta (la clase Persona no acepta la creacion de personas sino de sus derivadas).
Metodo abstracto
Metodo virtual
Hay dos buscadores, uno de mesas libres y otro (productos?)
Hay un menu que muestra la facturacion del dia y la guarda en un archivo txt, llamado que se almacena en el Desktop
Se utilizan dos sonidos diferentes, un beep corto y un beep largo
