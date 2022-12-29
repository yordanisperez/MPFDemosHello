# Aprendiendo los fundamentos de WPF con C#

WPF (Windows Presentation Foundation) es un marco de desarrollo de aplicaciones de escritorio de 
Microsoft que permite crear interfaces de usuario atractivas y modernas para Windows. 
WPF proporciona una amplia variedad de componentes gr�ficos y de interfaz de usuario 
que pueden utilizarse para crear aplicaciones de escritorio de alta calidad.

El proyecto `MPFDemosHello` en GitHub es una aplicaci�n de demostraci�n que 
muestra el uso de algunos de los componentes b�sicos de WPF en C# para la 
creaci�n de aplicaciones de escritorio. 
La aplicaci�n incluye ejemplos de c�mo utilizar componentes como 
Label, Button, TextBox y Checkbox, entre otros.
El proyecto es una buena forma de aprender sobre el uso de estos componentes y 
c�mo integrarlos en una aplicaci�n de escritorio.

## WPFDemoLabel
El componente `Label` se puede utilizar para mostrar texto o im�genes 
en la interfaz de usuario de una aplicaci�n.

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
un enlace hiperv�nculo en el texto "google".

El atributo `NavigateUri` de la etiqueta `Hyperlink` se utiliza para establecer 
la direcci�n URL a la que se dirigir� el enlace hiperv�nculo cuando 
se haga clic en �l. En este caso, se establece en "https://www.google.com", 
lo que significa que cuando se haga clic en el enlace hiperv�nculo, 
se abrir� una nueva pesta�a del navegador en la direcci�n URL especificada.

```
<TextBlock x:Name="tbHello">
   Hello <Bold>World</Bold>  Go to 
   <Hyperlink RequestNavigate="Hyperlink_RequestNavigate" NavigateUri="https://www.google.com">
      google
   </Hyperlink>
</TextBlock>
```

La sentencia `System.Diagnostics.Process.Start(e.Uri.AbsoluteUri)` se utiliza para iniciar 
un proceso en el sistema operativo. En este caso, se est� utilizando para abrir una 
direcci�n URL especificada en el navegador por defecto del sistema.

La clase `System.Diagnostics.Process` proporciona acceso a un proceso en el sistema 
operativo y permite iniciar, detener y monitorear procesos. 
El m�todo `Start` de la clase `Process` se utiliza para iniciar un proceso. 
El par�metro que se le pasa a este m�todo es la direcci�n URL que se quiere abrir en el navegador.

En este caso, se est� utilizando la propiedad `AbsoluteUri` del objeto `Uri` 
pasado como par�metro para obtener la direcci�n URL completa a partir del cual se cre� el objeto `Uri`. 
Esto se hace para asegurarse de que se abre la direcci�n URL correcta en el navegador.

## WPFDemoButton
La etiqueta Button tiene varios atributos que se pueden establecer para personalizar 
su apariencia y comportamiento. En este caso, se establece el atributo `Margin` en "10" 
para establecer el margen alrededor del componente Button. 
El atributo `Background` se establece en "Coral" para establecer el color de 
fondo del componente Button. El atributo `Foreground` se establece en "DarkBlue" 
para establecer el color del texto del componente Button.

Los atributos `MouseEnter`, `MouseLeave`, `Click` y `MouseDoubleClick` se utilizan para asignar
manejadores de eventos a los eventos del rat�n correspondientes. 
Esto permite que se ejecute c�digo espec�fico cuando se produzcan estos eventos.

El atributo `x:Name` se utiliza para dar un nombre al componente `Button` y puede 
utilizarse para hacer referencia al componente desde el c�digo. 
El atributo `ToolTip` se utiliza para establecer una descripci�n emergente 
que se mostrar� cuando el usuario ponga el cursor sobre el componente Button.
Los atributos `Width` y `Height` se utilizan para establecer el tama�o del componente Button.

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

