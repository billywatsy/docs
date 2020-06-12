﻿' <Snippet1>
Imports System.Resources

<Assembly: NeutralResourcesLanguage("en-US")> 

Public Class UILibrary
   Private Const nFields As Integer = 4

   Public Shared Function GetTitle() As String
      Dim retval As String = My.Resources.LibResources.Title
      If String.IsNullOrEmpty(retval) Then retval = "<No value>"

      Return retval
   End Function

   Public Shared Function GetFieldNames() As String()
      Dim fieldnames(nFields - 1) As String
      fieldnames(0) = My.Resources.LibResources.Name
      fieldnames(1) = My.Resources.LibResources.ID
      fieldnames(2) = My.Resources.LibResources.Born
      fieldnames(3) = My.Resources.LibResources.Hired
      Return fieldnames
   End Function

   Public Shared Function GetFieldLengths() As Integer()
      Dim fieldLengths(nFields - 1) As Integer
      fieldLengths(0) = Int32.Parse(My.Resources.LibResources.NameLength)
      fieldLengths(1) = Int32.Parse(My.Resources.LibResources.IDLength)
      fieldLengths(2) = Int32.Parse(My.Resources.LibResources.BornLength)
      fieldLengths(3) = Int32.Parse(My.Resources.LibResources.HiredLength)
      Return fieldLengths
   End Function
End Class
' </Snippet1>


Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    Friend Class LibResources
       
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MyCompany.Employees.LibResources", GetType(LibResources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Birthdate.
        '''</summary>
        Friend Shared ReadOnly Property Born() As String
            Get
                Return ResourceManager.GetString("Born", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 12.
        '''</summary>
        Friend Shared ReadOnly Property BornLength() As String
            Get
                Return ResourceManager.GetString("BornLength", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Hire Date.
        '''</summary>
        Friend Shared ReadOnly Property Hired() As String
            Get
                Return ResourceManager.GetString("Hired", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 12.
        '''</summary>
        Friend Shared ReadOnly Property HiredLength() As String
            Get
                Return ResourceManager.GetString("HiredLength", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ID.
        '''</summary>
        Friend Shared ReadOnly Property ID() As String
            Get
                Return ResourceManager.GetString("ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 12.
        '''</summary>
        Friend Shared ReadOnly Property IDLength() As String
            Get
                Return ResourceManager.GetString("IDLength", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Name.
        '''</summary>
        Friend Shared ReadOnly Property Name() As String
            Get
                Return ResourceManager.GetString("Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 25.
        '''</summary>
        Friend Shared ReadOnly Property NameLength() As String
            Get
                Return ResourceManager.GetString("NameLength", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Employee Database.
        '''</summary>
        Friend Shared ReadOnly Property Title() As String
            Get
                Return ResourceManager.GetString("Title", resourceCulture)
            End Get
        End Property
    End Class
End Namespace