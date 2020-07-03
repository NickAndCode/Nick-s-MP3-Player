<Window x:Name="NicksMediaPlayer" x:Class="NicksMediaPlayer.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:NicksMediaPlayer"
        Title="Nick's Media Player" Height="200" Width="500" WindowStyle="None" WindowStartupLocation="CenterScreen">
    <Grid>
        <Grid.Background>
            <LinearGradientBrush EndPoint="0.5,1" MappingMode="RelativeToBoundingBox" StartPoint="0.5,0">
                <GradientStop Color="#FF02010A" Offset="1"/>
                <GradientStop Color="White"/>
            </LinearGradientBrush>
        </Grid.Background>
        <Label x:Name="MyLabel" Content="Nick's Media Player" HorizontalAlignment="Left" Margin="110,0,0,0" VerticalAlignment="Top" Width="275" FontFamily="Verdana" FontSize="24" FontWeight="Bold" Background="Transparent">
            <Label.Foreground>
                <LinearGradientBrush EndPoint="0.5,1" MappingMode="RelativeToBoundingBox" StartPoint="0.5,0">
                    <GradientStop Color="Black" Offset="1"/>
                    <GradientStop Color="#FFD0D0D0"/>
                </LinearGradientBrush>
            </Label.Foreground>
        </Label>
        <TextBox x:Name="textBox" HorizontalAlignment="Left" Height="23" Margin="10,41,0,0" VerticalAlignment="Top" Width="356" FontFamily="Verdana" TextAlignment="Center" BorderBrush="Black" SelectionBrush="#FF929292" Background="White"/>
        <Button x:Name="openFileButton" Content="Open File" HorizontalAlignment="Right" Margin="0,41,9.556,0" VerticalAlignment="Top" Width="80" Click="OpenFileButton" Height="23" FontFamily="Verdana" Foreground="White" BorderBrush="Black">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
        <ProgressBar x:Name="progressBar" HorizontalAlignment="Left" Height="10" Margin="10,82,0,0" VerticalAlignment="Top" Width="356" BorderBrush="Black" OpacityMask="Black" Foreground="#FF3C2652" Background="White"/>
        <Button x:Name="timerButton" Content="" HorizontalAlignment="Right" VerticalAlignment="Top" Width="40" Margin="0,77,49.556,0" Foreground="White" BorderBrush="Black" Background="#FF4A4A4A"/>
        <Button x:Name="totalTime" Content="" HorizontalAlignment="Right" Margin="0,77,9.556,0" VerticalAlignment="Top" Width="40" Foreground="White" BorderBrush="Black" Background="#FF4A4A4A"/>
        <Button x:Name="playButton" Content="Play" HorizontalAlignment="Left" Margin="10,0,0,51.556" VerticalAlignment="Bottom" Width="80" Click="PlayButton" FontFamily="Verdana" BorderBrush="Black" Foreground="White" Height="18">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
        <Button x:Name="pauseButton" Content="Pause" HorizontalAlignment="Left" Margin="110,0,0,51.556" VerticalAlignment="Bottom" Width="80" Click="PauseButton" FontFamily="Verdana" BorderBrush="Black" Foreground="White" Height="18">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
        <Button x:Name="playLoopButton" Content="Repeat" HorizontalAlignment="Right" Margin="0,0,204.556,51.556" VerticalAlignment="Bottom" Width="80" Click="PlayLoopButton" FontFamily="Verdana" BorderBrush="Black" Foreground="White" Height="18">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
        <Button x:Name="stopButton" Content="Stop" HorizontalAlignment="Right" Margin="0,0,110.556,51.556" VerticalAlignment="Bottom" Width="80" Click="StopButton" FontFamily="Verdana" Foreground="White" BorderBrush="Black" Height="18">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
        <StatusBar x:Name="statusBar" HorizontalAlignment="Left" Height="21" Margin="0,0,-0.445,-0.111" VerticalAlignment="Bottom" Width="496" FontFamily="Verdana" Background="Black" Foreground="White">
            Welcome, Please Click The Open File Button.
        </StatusBar>
        <Button x:Name="exitButton" Content="Exit" HorizontalAlignment="Right" Margin="0,0,9.556,51.556" VerticalAlignment="Bottom" Width="80" Foreground="White" BorderBrush="Black" Click="ExitButton" FontFamily="Verdana">
            <Button.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF4A4A4A" Offset="1"/>
                    <GradientStop Color="#FFA5A0A0"/>
                </RadialGradientBrush>
            </Button.Background>
        </Button>
    </Grid>
</Window>
