# Nullable Types con C#

<p align="justify">
Existen  dos tipos de datos  en .NET: los tipos por referencia (reference types) y los tipos por valor (value types), como ejemplo de tipos por valor encontramos a las estructuras (struct), los enumerados (enum) y  los todos los tipos simples como son los caracteres (char) y los tipos númericos (double,int,float,short,long), como ejemplo de tipos de referencia tenemos a la clase cadena (string), la clase object y la clases definidas por el usuario (user defined classes).
</p>
<p align="justify">
Una de las diferencias entre ellos es que los tipos por valor siempre deben tener un valor  y nunca pueden contener un valor nulo (null),  mientras que para los tipos por referencia siempre tienen el valor null al crearse o bien se les puede asignar durante la ejecución del programa.
</p>
<p align="justify">
El problema se presenta cuando se trabaja con fuentes de persistencia y se necesita asignar el valor de un tipo de dato de estas fuentes hacia un tipo de dato simple de C#, por ejemplo en un archivo XML o en una base de datos un valor entero puede representarse como vacío o  null, entonces no es posible representar este valor en un tipo simple de C# ya que en el CLR un tipo por valor  no puede ser nunca nulo.
</p>
<p>
Desde la versión 2.0 de .NET es posible trabajar con <i>nullable types</i> en donde los tipos simples tienen la capacidad de tener valores nulos,  esto se logra agregándoles el modificador (?) al tipo de dato, así por ejemplo las siguientes variables además de ser del tipo simple son <i>Nullable Types</i>.
</p>
<pre>
int? a = null;
boolean b? = null;
</pre>
<p align="justify">
A estos tipos también se les puede aplicar el operador (??) llamado null coalescing operator (operador de coalescencia)   el cuál le aplica la comparativa al valor, si este es nulo entonces le asigna un valor predeterminado, por ejemplo si tienes un arreglo de objetos de tipo factura   y necesitas que ciertas propiedades tengan al menos un valor predeterminado, aplicamos la comparativa utilizando el operador (??) para las  que las propiedades con valores nulos tengan un valor predeterminado, esto se muestra en el siguiente programa:
</p>
<p align="justify">
Dentro del método <i>PrintInvoice</i> se muestra la utilización del operador (??), para tres propiedades del objeto factura:
</p>
<pre>
Console.WriteLine("Start Date: {0}", invoice.StartDate ?? DateTime.Today);
Console.WriteLine("Measure Unit: {0}", invoice.MeasureUnit ?? "NONE");
Console.WriteLine("Tax percent: {0}", invoice.TaxPercent ?? 16.00M);
</pre>
<p align="justify">
Este operador no solo trabaja con <i>nullable types</i> sino también con tipos por referencia como es el caso de la propiedad <i>MeasureUnit</i>  la cual es del tipo <b>String</b> un tipo por referencia, como en el siguiente fragmento de código:</p>
<pre>
Console.WriteLine("Measure Unit: {0}",invoice.MeasureUnit ?? "NONE");
</pre>
<p>Los <i>nullable types</i> en realidad corresponden a una estructura genérica del CLR llamada <b>System.Nullable</b>
</p>
