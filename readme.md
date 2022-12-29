# Aprendiendo los fundamentos de WPF con C#

WPF (Windows Presentation Foundation) es un marco de desarrollo de aplicaciones de escritorio de 
Microsoft que permite crear interfaces de usuario atractivas y modernas para Windows. 
WPF proporciona una amplia variedad de componentes gráficos y de interfaz de usuario 
que pueden utilizarse para crear aplicaciones de escritorio de alta calidad.

El proyecto `MPFDemosHello` en GitHub es una aplicación de demostración que 
muestra el uso de algunos de los componentes básicos de WPF en C# para la 
creación de aplicaciones de escritorio. 
La aplicación incluye ejemplos de cómo utilizar componentes como 
Label, Button, TextBox y Checkbox, entre otros.
El proyecto es una buena forma de aprender sobre el uso de estos componentes y 
cómo integrarlos en una aplicación de escritorio.

## WPFDemoLabel
El componente `Label` se puede utilizar para mostrar texto o imágenes 
en la interfaz de usuario de una aplicación.

La etiqueta Label tiene varios atributos que se pueden establecer 
para personalizar su apariencia y comportamiento. 
En este caso, se establece el atributo Margin en "16,16,16,7" para establecer 
el margen alrededor del componente Label. El atributo BorderBrush se establece en 
"Black" para establecer el color del borde alrededor del componente Label. 
Y el atributo BorderThickness se establece en "1" 
para establecer el grosor del borde alrededor del componente Label.

```
<Label Margin="16,16,16,7" BorderBrush="Black" BorderThickness="1">
   Texto a mostrar
</Label>
```
## WPFDemoLink
La etiqueta TextBlock tiene varios elementos secundarios que se pueden utilizar 
para dar formato al texto. En este caso, se utiliza la etiqueta `Bold` para hacer que el 
texto "World" aparezca en negrita y se utiliza la etiqueta `Hyperlink` para crear 
un enlace hipervínculo en el texto "google".

El atributo `NavigateUri` de la etiqueta `Hyperlink` se utiliza para establecer 
la dirección URL a la que se dirigirá el enlace hipervínculo cuando 
se haga clic en él. En este caso, se establece en "https://www.google.com", 
lo que significa que cuando se haga clic en el enlace hipervínculo, 
se abrirá una nueva pestaña del navegador en la dirección URL especificada.

```
<TextBlock x:Name="tbHello">
   Hello <Bold>World</Bold>  Go to 
   <Hyperlink RequestNavigate="Hyperlink_RequestNavigate" NavigateUri="https://www.google.com">
      google
   </Hyperlink>
</TextBlock>
```
