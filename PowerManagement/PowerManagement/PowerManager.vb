Public Class PowerManager

    ''' <summary>
    ''' Die Powermanagement Klasse verhindert den Energiesprmodus des Rechners sowie den Bildschirmschoner
    ''' http://msdn.microsoft.com/en-us/library/windows/desktop/aa373208%28v=vs.85%29.aspx
    ''' </summary>
    Private Declare Function SetThreadExecutionState Lib "kernel32" (ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE

    Public Enum EXECUTION_STATE As Integer

        'esFlags
        ES_CONTINUOUS = &H80000000
        ES_DISPLAY_REQUIRED = &H2 'Display Idle Timer zurücksetzen
        ES_SYSTEM_REQUIRED = &H1 'Setzt das System in den "working state"

    End Enum

    ''' <summary>
    ''' Deaktiviert den idle timer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PowerSaveOff() As EXECUTION_STATE
        Return SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_DISPLAY_REQUIRED Or EXECUTION_STATE.ES_CONTINUOUS)
    End Function

    ''' <summary>
    ''' Aktiviert den idle timer - Clear EXECUTION_STATE flag
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PowerSaveOn() As EXECUTION_STATE
        Return SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
    End Function

End Class
