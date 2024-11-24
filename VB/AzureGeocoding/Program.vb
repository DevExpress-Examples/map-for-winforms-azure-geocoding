Namespace AzureGeocoding

    Friend Module Program

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            ' To customize application configuration such as set high DPI settings or default font,
            ' see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize()
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace
