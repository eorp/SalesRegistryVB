'InputUtility.vb
'Created by Evgeniya O'Regan Pevchikh, 9/7/2013
'strating to build a library for future use
Option Strict On
Option Explicit On

Imports System.Text.RegularExpressions

''' <summary>
''' this class contains helper methods for validating user's input
''' and checking values range that can be used throughout the program
''' </summary>
''' <remarks></remarks>
Public Class InputUtility
    ''' <summary>
    ''' convert string provided into an integer
    ''' ensure that int is positive as well
    ''' </summary>
    ''' <param name="stringToConvert">string provided as user's input</param>
    ''' <param name="intOutValue">parameter to be converted to</param>
    ''' <returns>true if input can be converted into integer, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer) As Boolean
        If (Integer.TryParse(stringToConvert, intOutValue)) Then
            If (IsPositiveInt(intOutValue)) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' check if the integer provided is a positive number
    ''' </summary>
    ''' <param name="checkInt">integer to be checked</param>
    ''' <returns>true if its a positive number, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function IsPositiveInt(ByVal checkInt As Integer) As Boolean
        Return checkInt > 0
    End Function

    ''' <summary>
    ''' convert user's input into double
    ''' ensure that double is positive as well
    ''' </summary>
    ''' <param name="stringToConvert">user's input</param>
    ''' <param name="dblOutValue">parameter to be converted to</param>
    ''' <returns>true or false depending on the result</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double) As Boolean
        If (Double.TryParse(stringToConvert, dblOutValue)) Then
            If (IsPositiveDouble(dblOutValue)) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' check if double is positive
    ''' </summary>
    ''' <param name="checkDbl">double to be checked</param>
    ''' <returns>true or false depending on the result</returns>
    ''' <remarks></remarks>
    Public Shared Function IsPositiveDouble(ByVal checkDbl As Double) As Boolean
        Return checkDbl > 0.0
    End Function
    ''' <summary>
    ''' check whether a string provided is not null, blank and contains at least one 
    ''' character 
    ''' </summary>
    ''' <param name="stringToCheck">string to be checked</param>
    ''' <returns>true if string is invalid, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function IsInvalidString(ByVal stringToCheck As String) As Boolean
        'trim string
        Dim trimStr = stringToCheck.Trim()
        Return String.IsNullOrEmpty(trimStr)
    End Function
    ''' <summary>
    ''' check if a field in a listbox is selected
    ''' </summary>
    ''' <param name="index">selected index</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckIndex(ByVal index As Integer) As Boolean
        If (index < 0) Then
            Return False
        End If
        Return True
    End Function
    ''' <summary>
    ''' an overload method for the one above with the same name 
    ''' checkig if the string provided can be converted into an int
    ''' and it's within min and max range provided
    ''' </summary>
    ''' <param name="stringToConvert">string provided</param>
    ''' <param name="intOutValue">putput parameter to be converted to</param>
    ''' <param name="minLimit">min range</param>
    ''' <param name="maxLimit">max range</param>
    ''' <returns>true or false depending on the result</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer, ByVal minLimit As Integer, ByVal maxLimit As Integer) As Boolean
        If (Integer.TryParse(stringToConvert, intOutValue)) Then
            If ((intOutValue >= minLimit) And (intOutValue <= maxLimit)) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' an overload method to check if the string can be converted into an int
    ''' and it is at least the value or more of the provided min range
    ''' </summary>
    ''' <param name="stringToConvert">string provided</param>
    ''' <param name="intOutValue">converted int value</param>
    ''' <param name="minLimit">min range</param>
    ''' <returns>true if the input satisfies all conditions, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer, ByVal minLimit As Integer) As Boolean
        If (Integer.TryParse(stringToConvert, intOutValue)) Then
            If (intOutValue >= minLimit) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' an overload method to convert an input into double and
    ''' ensure it's within a given range
    ''' </summary>
    ''' <param name="stringToConvert">input</param>
    ''' <param name="dblOutValue">converted double value</param>
    ''' <param name="minLimit">min range</param>
    ''' <param name="maxLimit">max range</param>
    ''' <returns>true if input satisfies all conditions, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, ByVal minLimit As Double, ByVal maxLimit As Double) As Boolean
        If (Double.TryParse(stringToConvert, dblOutValue)) Then
            If ((dblOutValue >= minLimit) And (dblOutValue <= maxLimit)) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' an overload function similar to the one above which includes only 
    ''' the min range
    ''' </summary>
    ''' <param name="stringToConvert">input</param>
    ''' <param name="dblOutValue">converted double value</param>
    ''' <param name="minLimit">min range</param>
    ''' <returns>true if all conditions satisfied, false otherwise</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, ByVal minLimit As Double) As Boolean
        If (Double.TryParse(stringToConvert, dblOutValue)) Then
            If (dblOutValue >= minLimit) Then
                Return True
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' this method generates a random integer in the range provided
    ''' </summary>
    ''' <param name="first">start range (including this number)</param>
    ''' <param name="last">end range (excluding this number)</param>
    ''' <returns>random int from the range</returns>
    ''' <remarks></remarks>
    Public Shared Function GetRandom(ByVal first As Integer, ByVal last As Integer) As Integer
        Dim rand As New Random()
        Return rand.Next(first, last)
    End Function

    Public Shared Function IsValidEmail(ByVal email As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(email, "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
    End Function
End Class
