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

La sentencia `System.Diagnostics.Process.Start(e.Uri.AbsoluteUri)` se utiliza para iniciar 
un proceso en el sistema operativo. En este caso, se está utilizando para abrir una 
dirección URL especificada en el navegador por defecto del sistema.

La clase `System.Diagnostics.Process` proporciona acceso a un proceso en el sistema 
operativo y permite iniciar, detener y monitorear procesos. 
El método `Start` de la clase `Process` se utiliza para iniciar un proceso. 
El parámetro que se le pasa a este método es la dirección URL que se quiere abrir en el navegador.

En este caso, se está utilizando la propiedad `AbsoluteUri` del objeto `Uri` 
pasado como parámetro para obtener la dirección URL completa a partir del cual se creó el objeto `Uri`. 
Esto se hace para asegurarse de que se abre la dirección URL correcta en el navegador.

## WPFDemoButton
La etiqueta Button tiene varios atributos que se pueden establecer para personalizar 
su apariencia y comportamiento. En este caso, se establece el atributo `Margin` en "10" 
para establecer el margen alrededor del componente Button. 
El atributo `Background` se establece en "Coral" para establecer el color de 
fondo del componente Button. El atributo `Foreground` se establece en "DarkBlue" 
para establecer el color del texto del componente Button.

Los atributos `MouseEnter`, `MouseLeave`, `Click` y `MouseDoubleClick` se utilizan para asignar
manejadores de eventos a los eventos del ratón correspondientes. 
Esto permite que se ejecute código específico cuando se produzcan estos eventos.

El atributo `x:Name` se utiliza para dar un nombre al componente `Button` y puede 
utilizarse para hacer referencia al componente desde el código. 
El atributo `ToolTip` se utiliza para establecer una descripción emergente 
que se mostrará cuando el usuario ponga el cursor sobre el componente Button.
Los atributos `Width` y `Height` se utilizan para establecer el tamaño del componente Button.

```
<Button Margin="10" 
        Background="Coral"
        Foreground="DarkBlue"
        MouseEnter="btClick_MouseEnter"
        MouseLeave="btClick_MouseLeave"
        x:Name="btClick" 
        ToolTip="Click Me!!!"
        Width="100" 
        Height="30" 
        Click="btClick_Click"
        MouseDoubleClick="btClick_MouseDoubleClick"
        >Click Me!!!

</Button>

```

