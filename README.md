# MediaPlayer

Este é um aplicativo de media player simples desenvolvido em WPF.

## Pré-requisitos

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) instalado na máquina.

## Como executar o projeto

1. Clone o repositório ou faça o download dos arquivos do projeto.

2. Abra o projeto no Visual Studio (ou qualquer outra IDE compatível com WPF).

3. Certifique-se de que o projeto de inicialização esteja configurado corretamente como `MainWindow.xaml`.

4. Compile o projeto para garantir que não há erros.

5. Execute o aplicativo pressionando F5 ou clicando no botão "Iniciar" na barra de ferramentas.

6. O MediaPlayer será iniciado e você poderá arrastar e soltar um arquivo de vídeo na janela para reproduzi-lo. Use os botões "Play", "Pause" e "Stop" para controlar a reprodução do vídeo. A barra de controle deslizante permite ajustar a posição de reprodução e o volume do vídeo.

7. Aproveite o MediaPlayer!

## Personalização

- Você pode personalizar a aparência do MediaPlayer ajustando as propriedades de estilo no arquivo XAML (`MainWindow.xaml`) e as propriedades de aparência no código C# (`ViewModel.cs`).

## Descrição da arquitetura da aplicação

A aplicação segue a arquitetura MVVM (Model-View-ViewModel). Os principais componentes da arquitetura são:

- Models: A pasta `Models` contém as classes de modelo que representam os dados e o estado da aplicação. No caso do MediaPlayer, o modelo `MediaPlayerModel` define as propriedades relacionadas à reprodução de mídia, como o caminho do vídeo, o estado de reprodução, a posição de reprodução e o volume.

- ViewModel: A pasta `ViewModel` contém a classe `ViewModel` que atua como intermediária entre o modelo e a interface do usuário (view). A ViewModel gerencia o estado e o comportamento da aplicação, incluindo a reprodução de mídia. Ela possui propriedades que são vinculadas à interface do usuário e métodos para controlar a reprodução do vídeo.

- View: A pasta `View` contém os arquivos XAML que definem a interface do usuário. O arquivo `MainWindow.xaml` representa a janela principal da aplicação e contém os elementos visuais, como botões, barras de controle deslizante e o elemento de mídia para reprodução do vídeo. A interface do usuário é vinculada à ViewModel por meio de bindings para refletir as alterações de estado e permitir a interação do usuário.

## Descrição do funcionamento do sistema

O MediaPlayer é um aplicativo que permite reproduzir vídeos de forma simples. Ao iniciar o aplicativo, você pode arrastar e soltar um arquivo de vídeo na janela do MediaPlayer. O vídeo será carregado e reproduzido automaticamente. Você pode controlar a reprodução usando os botões "Play", "Pause" e "Stop". A barra de controle deslizante permite ajustar a posição de reprodução do vídeo e o nível de volume.

A aplicação segue o padrão MVVM, onde o modelo (`MediaPlayerModel`) contém as propriedades relacionadas à reprodução de mídia, a ViewModel (`ViewModel`) gerencia o estado e o comportamento da aplicação, e a View (`MainWindow.xaml`) exibe a interface do usuário e interage com a ViewModel por meio de bindings.

Com base nessa arquitetura, o MediaPlayer fornece uma experiência intuitiva e fácil de usar para reproduzir vídeos, oferecendo controle total sobre a reprodução, a posição de reprodução e o volume.
