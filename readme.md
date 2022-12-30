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
## WPFDemoTextBlock

El primer elemento `TextBlock` tiene el atributo `TextTrimming` establecido en "WordEllipsis", 
lo que significa que si el texto es demasiado largo para caber en el espacio disponible, 
se mostrar�n puntos suspensivos para indicar que hay m�s texto disponible.

El segundo elemento `TextBlock` tiene el atributo `TextWrapping` establecido en "Wrap", 
lo que significa que si el texto es demasiado largo para caber en el espacio disponible, 
se mostrar� en varias l�neas.

El tercer elemento `TextBlock` tiene el atributo `TextWrapping` establecido en "WrapWithOverflow", 
lo que significa que si el texto es demasiado largo para caber en el espacio disponible, 
se mostrar� en varias l�neas y se mostrar� una barra de desplazamiento para 
permitir al usuario desplazarse por el texto. 
Adem�s, el elemento `TextBlock` tiene el atributo `Foreground` establecido en "Blue" para 
establecer el color del texto y contiene un elemento `Span` con el atributo `Foreground` 
establecido en "red" para cambiar el color de una parte del texto.

```
        <TextBlock TextTrimming="WordEllipsis">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
            sed do eiusmod tempor incididunt ut labore et dolore magna 
            aliqua. Dolor magna eget est lorem. Morbi blandit cursus risus at 
            ultrices mi. Congue eu consequat ac felis donec et odio pellentesque. 
            Fames ac turpis egestas maecenas pharetra convallis posuere. 
            Massa placerat duis ultricies lacus.
        </TextBlock>
        <Separator Margin="5"></Separator>
        <TextBlock TextWrapping="Wrap">
            Loremipsumdolorsitamet,consecteturadipiscingelit,seddoeiusmod 
            tempor incididunt ut labore et dolore magna aliqua. Dolor magna 
            eget est lorem. Morbi blandit cursus risus at ultrices mi. 
            Congue eu consequat ac felis donec et odio pellentesque. 
            Fames ac turpis egestas maecenas pharetra convallis posuere. 
            Massa placerat duis ultricies lacus.
        </TextBlock>
        <Separator Margin="5"></Separator>
        <TextBlock TextWrapping="WrapWithOverflow" Foreground="Blue">
            Loremipsumdolorsitamet,consecteturadipiscingelit,seddoeiusmod tempor 
            <Span Foreground="red">incididunt ut labore</Span>  
            et dolore magna aliqua. Dolor magna eget est lorem. 
            Morbi blandit cursus risus at ultrices mi. 
            Congue eu consequat ac felis donec et odio pellentesque. 
            Fames ac turpis egestas maecenas pharetra convallis posuere. 
            Massa placerat duis ultricies lacus.
        </TextBlock>
```
## WPFDemoTextBox

La etiqueta `TextBox` tiene varios atributos que se pueden establecer para personalizar 
su apariencia y comportamiento. 
En este caso, se establece el atributo `FontSize` en "30" para establecer el 
tama�o de la fuente del texto en el componente TextBox. El atributo `Margin` se establece en "15" 
para establecer el margen alrededor del componente `TextBox`. El atributo `AcceptsReturn` 
se establece en "True" para permitir que el usuario inserte saltos de l�nea en el texto 
del componente `TextBox` utilizando la tecla `Enter`.

El atributo `TextWrapping` se establece en "Wrap" para permitir que el texto se 
muestre en varias l�neas si es demasiado largo para caber en el espacio disponible. 
El atributo `SpellCheck.IsEnabled` se establece en "True" para habilitar la revisi�n 
ortogr�fica del texto del componente `TextBox`. 
El atributo `Language` se establece en "en-US" para establecer el idioma del texto 
del componente `TextBox` en ingl�s.

```
       <TextBox 
            FontSize="30" 
            Margin="15" 
            AcceptsReturn="True" 
            TextWrapping="Wrap"
            SpellCheck.IsEnabled="True"
            Language="en-US"
            Background="AliceBlue"
            Foreground="Black"
            Text="Hello world"
            IsReadOnly="True"
            />
```

## WPFDemoSlider

El elemento Slider tiene varios atributos que se pueden establecer para personalizar 
su apariencia y comportamiento. En este caso, se establece el atributo `x:Name` en "slMyslider" 
para darle un nombre al componente `Slider` y poder hacer referencia a �l desde el c�digo.
El atributo `Minimum` se establece en "10" para establecer el valor m�nimo del componente `Slider`. 
El atributo `Maximum` se establece en "50" para establecer el valor m�ximo del componente `Slider`. 
El atributo `IsSnapToTickEnabled` se establece en "true" para hacer que el componente `Slider` 
se ajuste autom�ticamente al valor m�s cercano de la escala de valores 
cuando se suelta el bot�n del rat�n.

El atributo `TickPlacement` se establece en "BottomRight" para mostrar las marcas de escala del 
componente.

El `binding` es una caracter�stica de `WPF` que permite enlazar una propiedad de un elemento de 
interfaz de usuario con una fuente de datos. 
Esto permite que el valor de la propiedad se actualice autom�ticamente cuando cambia el 
valor de la fuente de datos y viceversa.

Se establece un binding entre el elemento `TextBlock` y el elemento `Slider`. 
El elemento `TextBlock` tiene el atributo `FontSize` establecido en una expresi�n de binding 
que hace referencia al elemento `Slider` con el nombre "slMyslider" y a su propiedad "Value".
Esto significa que el tama�o de la fuente del elemento `TextBlock` se actualizar� autom�ticamente 
cuando cambie el valor del elemento `Slider`
.
La expresi�n de binding tambi�n incluye el atributo `UpdateSourceTrigger` establecido 
en "PropertyChanged", lo que significa que la fuente de datos se actualizar� cada vez que 
cambie la propiedad del elemento `Slider`.

```
        <Slider x:Name="slMyslider" 
                Minimum="10"
                Maximum="50" 
                IsSnapToTickEnabled="true"
                TickPlacement="BottomRight" 
                TickFrequency="2" 
                Value="15"
                ValueChanged="slMyslider_ValueChanged"
                >
        </Slider>
        <TextBlock x:Name="tbValueSlider" FontSize="{Binding ElementName=slMyslider , Path=Value ,UpdateSourceTrigger=PropertyChanged}"></TextBlock>
```
## WPFDemoRadioButton

El elemento `RadioButton` tiene varios atributos que se pueden establecer para 
personalizar su apariencia y comportamiento. 
En este caso, se establece el atributo `x:Name` en "rbObama" para darle un nombre al 
componente `RadioButton` y poder hacer referencia a �l desde el c�digo. Los atributos
`Checked` y `Unchecked` se establecen en los nombres de los controladores de eventos
"rbObama_Checked" y "rbObama_Unchecked" respectivamente, para especificar 
los m�todos que se deben ejecutar cuando el componente `RadioButton` se selecciona o deselecciona.

El atributo `GroupName` se establece en "Presidents" para agrupar el componente RadioButton 
con otros componentes `RadioButton` que tengan el mismo valor de `GroupName`. 
Esto significa que solo un componente `RadioButton` del grupo puede estar seleccionado a la vez. 
El atributo `VerticalContentAlignment` se establece en "Center" 
para centrar el contenido del componente `RadioButton` verticalmente. 
El atributo `Margin` se establece en "0,3" para establecer el margen alrededor del 
componente `RadioButton`.
```
<RadioButton x:Name="rbObama" Checked="rbObama_Checked" Unchecked="rbObama_Unchecked" GroupName="Presidents" VerticalContentAlignment="Center" Margin="0,3" >
    <Label  Margin="0" Padding="0" >
        <WrapPanel  Orientation="Horizontal">
            <Image Width="20" Source="/obama.jpg">
            </Image>
            <AccessText Margin="5,0,0,0" FontSize="18"  Text="Obama"></AccessText>
        </WrapPanel>
    </Label>
</RadioButton>
```
## WPFCheckboxDemo

El elemento `CheckBox` tiene varios atributos que se pueden establecer para personalizar su 
apariencia y comportamiento. En este caso, se establece el atributo `Margin` en "15,5" para 
establecer el margen alrededor del componente `CheckBox`. 
El atributo `x:Name` se establece en "cbCheese" para darle un nombre al componente `CheckBox`
y poder hacer referencia a �l desde el c�digo. El atributo `VerticalContentAlignment` 
se establece en "Center" para centrar el contenido del componente `CheckBox` verticalmente.

Los atributos `Checked` y `Unchecked` se establecen en los nombres de los controladores 
de eventos "changeChildrenPizza" para especificar el m�todo que se debe ejecutar 
cuando el componente `CheckBox` se selecciona o deselecciona.

```
<CheckBox Margin="15,5" x:Name="cbCheese" VerticalContentAlignment="Center" Checked="changeChildrenPizza" Unchecked="changeChildrenPizza">
    <Label x:Name="lbCheese" Margin="0" Padding="0" >
        <WrapPanel  Orientation="Horizontal">
            <Image Width="20" Source="/extracheese.jpg">
            </Image>
            <AccessText Margin="5,0,0,0" FontSize="18" Text="Extra Cheese"></AccessText>
        </WrapPanel>
    </Label>
</CheckBox>

```

## WPFDemoMenu

Se muestra un elemento `DockPanel` que se puede utilizar para organizar elementos de 
interfaz de usuario en un panel de acuerdo con una de las cuatro direcciones 
(arriba, abajo, izquierda o derecha).

Dentro del elemento `DockPanel`, se encuentra un elemento `Menu` que se puede 
utilizar para crear un men� de opciones en la interfaz de usuario. 
El elemento `Menu` tiene el atributo `DockPanel.Dock` establecido en "Top" para indicar 
que el elemento Menu debe anclarse a la parte superior del panel.

Dentro del elemento `Menu`, hay un elemento `MenuItem` con el atributo `Header`
establecido en "File". Este elemento `MenuItem` es un elemento principal del men� 
y puede tener subelementos `MenuItem` que representan opciones disponibles en el men�. 
En este caso, hay dos subelementos `MenuItem` con los encabezados "New" y "Open".

El primer subelemento `MenuItem` con el encabezado "New" tiene dos subelementos `MenuItem` 
con los encabezados "Project" y "Repository". 
Estos elementos MenuItem tienen el atributo `Click` establecido en el nombre del 
controlador de eventos "MenuItem_Click" para especificar el m�todo que se debe 
ejecutar cuando se hace clic en el elemento `MenuItem`.

```
<DockPanel>
    <Menu DockPanel.Dock="Top">
        <MenuItem Header="File">
            <MenuItem Header="New">
                <MenuItem Header="Project" Click="MenuItem_Click">
                    <MenuItem.Icon>
                        <Image Source="https://pic.onlinewebfonts.com/svg/img_99548.png"></Image>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Repository">
                    <MenuItem.Icon>
                        <Image Source="https://pic.onlinewebfonts.com/svg/img_474388.png"></Image>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>
            <MenuItem Header="Open"></MenuItem>

        </MenuItem>
    </Menu>
</DockPanel>
```