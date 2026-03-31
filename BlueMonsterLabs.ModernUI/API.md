# BlueMonsterLabs.ModernUI API Documentation

## Type: BlueMonsterLabs.ModernUI.ModernUIHelper
**Summary:** Provides various common helper methods.

### Property: BlueMonsterLabs.ModernUI.ModernUIHelper.IsInDesignMode
Determines whether the current code is executed in a design time environment such as Visual Studio or Blend.

### Method: BlueMonsterLabs.ModernUI.ModernUIHelper.GetDpiAwareness()
Gets the DPI awareness of the current process.

### Method: BlueMonsterLabs.ModernUI.ModernUIHelper.TrySetPerMonitorDpiAware()
Attempts to set the DPI awareness of this process to PerMonitorDpiAware.

## Type: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager
**Summary:** Manages the theme, font size and accent colors for a Modern UI application.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.DarkThemeSource
The location of the dark theme resource dictionary.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.LightThemeSource
The location of the light theme resource dictionary.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.KeyAccentColor
The resource key for the accent color.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.KeyAccent
The resource key for the accent brush.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.KeyDefaultFontSize
The resource key for the default font size.

### Field: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.KeyFixedFontSize
The resource key for the fixed font size.

### Method: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.Current
Gets the current instance.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.DarkThemeCommand
The command that sets the dark theme.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.LightThemeCommand
The command that sets the light color theme.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.SetThemeCommand
The command that sets a custom theme.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.LargeFontSizeCommand
The command that sets the large font size.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.SmallFontSizeCommand
The command that sets the small font size.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.AccentColorCommand
The command that sets the accent color.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.ThemeSource
Gets or sets the current theme source.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.FontSize
Gets or sets the font size.

### Property: BlueMonsterLabs.ModernUI.Presentation.AppearanceManager.AccentColor
Gets or sets the accent color.

## Type: BlueMonsterLabs.ModernUI.Presentation.CommandBase
**Summary:** The base implementation of a command.

### Event: BlueMonsterLabs.ModernUI.Presentation.CommandBase.CanExecuteChanged
Occurs when changes occur that affect whether or not the command should execute.

### Method: BlueMonsterLabs.ModernUI.Presentation.CommandBase.OnCanExecuteChanged()
Raises the event.

### Method: BlueMonsterLabs.ModernUI.Presentation.CommandBase.CanExecute(System.Object)
Defines the method that determines whether the command can execute in its current state.

### Method: BlueMonsterLabs.ModernUI.Presentation.CommandBase.Execute(System.Object)
Defines the method to be called when the command is invoked.

### Method: BlueMonsterLabs.ModernUI.Presentation.CommandBase.OnExecute(System.Object)
Executes the command.

## Type: BlueMonsterLabs.ModernUI.Presentation.Displayable
**Summary:** Provides a base implementation for objects that are displayed in the UI.

### Property: BlueMonsterLabs.ModernUI.Presentation.Displayable.DisplayName
Gets or sets the display name.

## Type: BlueMonsterLabs.ModernUI.Presentation.FontSize
**Summary:** Identifies the available font size.

### Field: BlueMonsterLabs.ModernUI.Presentation.FontSize.Large
Large fonts.

### Field: BlueMonsterLabs.ModernUI.Presentation.FontSize.Small
Small fonts.

## Type: BlueMonsterLabs.ModernUI.Presentation.Link
**Summary:** Represents a displayable link.

### Property: BlueMonsterLabs.ModernUI.Presentation.Link.Source
Gets or sets the source uri.

## Type: BlueMonsterLabs.ModernUI.Presentation.LinkCollection
**Summary:** Represents an observable collection of links.

### Method: BlueMonsterLabs.ModernUI.Presentation.LinkCollection.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Presentation.LinkCollection.#ctor(System.Collections.Generic.IEnumerable{BlueMonsterLabs.ModernUI.Presentation.Link})
Initializes a new instance of the class that contains specified links.

## Type: BlueMonsterLabs.ModernUI.Presentation.LinkGroup
**Summary:** Represents a named group of links.

### Property: BlueMonsterLabs.ModernUI.Presentation.LinkGroup.GroupKey
Gets or sets the key of the group.

### Property: BlueMonsterLabs.ModernUI.Presentation.LinkGroup.SelectedLink
Gets or sets the selected link in this group.

### Property: BlueMonsterLabs.ModernUI.Presentation.LinkGroup.Links
Gets the links.

## Type: BlueMonsterLabs.ModernUI.Presentation.LinkGroupCollection
**Summary:** Represents an observable collection of link groups.

## Type: BlueMonsterLabs.ModernUI.Presentation.NotifyPropertyChanged
**Summary:** The base implementation of the INotifyPropertyChanged contract.

### Event: BlueMonsterLabs.ModernUI.Presentation.NotifyPropertyChanged.PropertyChanged
Occurs when a property value changes.

### Method: BlueMonsterLabs.ModernUI.Presentation.NotifyPropertyChanged.OnPropertyChanged(System.String)
Raises the PropertyChanged event.

### Method: BlueMonsterLabs.ModernUI.Presentation.NotifyPropertyChanged.Set``1(``0@,``0,System.String)
Updates specified value, and raises the event when the value has changed.

## Type: BlueMonsterLabs.ModernUI.Presentation.ReadOnlyLinkGroupCollection
**Summary:** Represents a read-only observable collection of link groups.

### Method: BlueMonsterLabs.ModernUI.Presentation.ReadOnlyLinkGroupCollection.#ctor(BlueMonsterLabs.ModernUI.Presentation.LinkGroupCollection)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Presentation.ReadOnlyLinkGroupCollection.List
Provides access to the wrapped list.

## Type: BlueMonsterLabs.ModernUI.Presentation.RelayCommand
**Summary:** The command that relays its functionality by invoking delegates.

### Method: BlueMonsterLabs.ModernUI.Presentation.RelayCommand.#ctor(System.Action{System.Object},System.Func{System.Object,System.Boolean})
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Presentation.RelayCommand.CanExecute(System.Object)
Defines the method that determines whether the command can execute in its current state.

### Method: BlueMonsterLabs.ModernUI.Presentation.RelayCommand.OnExecute(System.Object)
Executes the command.

## Type: BlueMonsterLabs.ModernUI.ProcessDpiAwareness
**Summary:** Identifies dots per inch (dpi) awareness values.

### Field: BlueMonsterLabs.ModernUI.ProcessDpiAwareness.DpiUnaware
Process is not DPI aware.

### Field: BlueMonsterLabs.ModernUI.ProcessDpiAwareness.SystemDpiAware
Process is system DPI aware (= WPF default).

### Field: BlueMonsterLabs.ModernUI.ProcessDpiAwareness.PerMonitorDpiAware
Process is per monitor DPI aware (Win81+ only).

## Type: BlueMonsterLabs.ModernUI.Resources
**Summary:** A strongly-typed resource class, for looking up localized strings, etc.

### Property: BlueMonsterLabs.ModernUI.Resources.ResourceManager
Returns the cached ResourceManager instance used by this class.

### Property: BlueMonsterLabs.ModernUI.Resources.Culture
Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

### Property: BlueMonsterLabs.ModernUI.Resources.Back
Looks up a localized string similar to back.

### Property: BlueMonsterLabs.ModernUI.Resources.Cancel
Looks up a localized string similar to cancel.

### Property: BlueMonsterLabs.ModernUI.Resources.Close
Looks up a localized string similar to close.

### Property: BlueMonsterLabs.ModernUI.Resources.Maximize
Looks up a localized string similar to maximize.

### Property: BlueMonsterLabs.ModernUI.Resources.Minimize
Looks up a localized string similar to minimize.

### Property: BlueMonsterLabs.ModernUI.Resources.NavigateLink
Looks up a localized string similar to Navigate link.

### Property: BlueMonsterLabs.ModernUI.Resources.NavigationFailed
Looks up a localized string similar to Navigation failed.

### Property: BlueMonsterLabs.ModernUI.Resources.NavigationFailedFrameNotFound
Looks up a localized string similar to Unable to navigate to {0}, could not find a ModernFrame target '{1}'.

### Property: BlueMonsterLabs.ModernUI.Resources.NavigationFailedSourceNotSpecified
Looks up a localized string similar to Unable to navigate to {0}, no source specified.

### Property: BlueMonsterLabs.ModernUI.Resources.No
Looks up a localized string similar to no.

### Property: BlueMonsterLabs.ModernUI.Resources.Ok
Looks up a localized string similar to ok.

### Property: BlueMonsterLabs.ModernUI.Resources.Restore
Looks up a localized string similar to restore.

### Property: BlueMonsterLabs.ModernUI.Resources.UIThreadRequired
Looks up a localized string similar to Operation requires the UI thread.

### Property: BlueMonsterLabs.ModernUI.Resources.UnexpectedToken
Looks up a localized string similar to Unexpected token.

### Property: BlueMonsterLabs.ModernUI.Resources.UnknownOS
Looks up a localized string similar to Unknown operating system.

### Property: BlueMonsterLabs.ModernUI.Resources.UnknownTokenType
Looks up a localized string similar to Unknown token type.

### Property: BlueMonsterLabs.ModernUI.Resources.Yes
Looks up a localized string similar to yes.

## Type: BlueMonsterLabs.ModernUI.Windows.CommandDictionary
**Summary:** Represents a collection of commands keyed by a uri.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock
**Summary:** A lighweight control for displaying small amounts of rich formatted BBCode content.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock.BBCodeProperty
Identifies the BBCode dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock.LinkNavigatorProperty
Identifies the LinkNavigator dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock.BBCode
Gets or sets the BB code.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCodeBlock.LinkNavigator
Gets or sets the link navigator.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer
**Summary:** The BBCode lexer.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.TokenStartTag
Start tag

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.TokenEndTag
End tag

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.TokenAttribute
Attribute

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.TokenText
Text

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.TokenLineBreak
Line break

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.StateNormal
Normal state

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.StateTag
Tag state

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.#ctor(System.String)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.DefaultState
Gets the default state of the lexer.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeLexer.NextToken()
Gets the next token.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeParser
**Summary:** Represents the BBCode parser.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeParser.ParseContext.CreateRun(System.String)
Creates a run reflecting the current context settings.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeParser.#ctor(System.String,System.Windows.FrameworkElement)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeParser.Commands
Gets or sets the available navigable commands.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.BBCodeParser.Parse()
Parses the text and returns a Span containing the parsed result.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer
**Summary:** Represents a character buffer.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer.#ctor(System.String)
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer.LA(System.Int32)
Performs a look-ahead.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer.Mark()
Marks the current position.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer.GetMark()
Gets the mark.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.CharBuffer.Consume()
Consumes the next character.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer
**Summary:** Provides basic lexer functionality.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.TokenEnd
Defines the end-of-file token type.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.#ctor(System.String)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.DefaultState
Gets the default state of the lexer.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.State
Gets the current state of the lexer.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.PushState(System.Int32)
Pushes a new state on the stac.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.PopState()
Pops the state.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.LA(System.Int32)
Performs a look-ahead.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.Mark()
Marks the current position.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.GetMark()
Gets the mark.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.Consume()
Consumes the next character.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.IsInRange(System.Char,System.Char)
Determines whether the current character is in given range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.IsInRange(System.Char[])
Determines whether the current character is in given range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.Match(System.Char)
Matches the specified character.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.Match(System.Char,System.Int32,System.Int32)
Matches the specified character.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.Match(System.String)
Matches the specified string.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.MatchRange(System.Char[])
Matches the range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.MatchRange(System.Char[],System.Int32,System.Int32)
Matches the range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.MatchRange(System.Char,System.Char)
Matches the range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.MatchRange(System.Char,System.Char,System.Int32,System.Int32)
Matches the range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer.NextToken()
Gets the next token.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.ParseException
**Summary:** The exception for parse errors.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.ParseException.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.ParseException.#ctor(System.String)
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.ParseException.#ctor(System.String,System.Exception)
Initializes a new instance of the class.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1
**Summary:** Provides basic parse functionality.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer)
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.LA(System.Int32)
Performs a token look-ahead

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.Consume()
Consumes the next token.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.IsInRange(System.Int32[])
Determines whether the current token is in specified range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.Match(System.Int32)
Matches the specified token type.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.MatchNot(System.Int32)
Does not matches the specified token type

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.MatchRange(System.Int32[],System.Int32,System.Int32)
Matches the range.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Parser`1.Parse()
Parses the text and returns an object of type TResult.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token
**Summary:** Represents a single token.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token.End
Represents the token that marks the end of the input.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token.#ctor(System.String,System.Int32)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token.Value
Gets the value.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token.TokenType
Gets the type of the token.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Token.ToString()
Returns a that represents the current .

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.TokenBuffer
**Summary:** Represents a token buffer.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.TokenBuffer.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.Lexer)
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.TokenBuffer.LA(System.Int32)
Performs a look-ahead.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.BBCode.TokenBuffer.Consume()
Consumes the next token.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridCheckBoxColumn
**Summary:** A DataGrid checkbox column using default Modern UI element styles.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridCheckBoxColumn.#ctor()
Initializes a new instance of the class.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridComboBoxColumn
**Summary:** A DataGrid checkbox column using default Modern UI element styles.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridComboBoxColumn.#ctor()
Initializes a new instance of the class.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridTextColumn
**Summary:** A DataGrid text column using default Modern UI element styles.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DataGridTextColumn.#ctor()
Initializes a new instance of the class.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow
**Summary:** A window instance that is capable of per-monitor DPI awareness when supported.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow.DpiChanged
Occurs when the system or monitor DPI for this window has changed.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow.DpiInformation
Gets the DPI information for this window instance.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow.OnDpiChanged(System.Windows.DpiScale,System.Windows.DpiScale)
Called when the DPI at which this window is rendered changes.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.DpiAwareWindow.OnDpiChanged(System.EventArgs)
Raises the event.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation
**Summary:** Provides DPI information for a window.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.WpfDpiX
Gets the horizontal resolution of the WPF rendering DPI.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.WpfDpiY
Gets the vertical resolution of the WPF rendering DPI.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.MonitorDpiX
Gets the horizontal resolution of the current monitor DPI.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.MonitorDpiY
Gets the vertical resolution of the current monitor DPI.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.ScaleX
Gets the x-axis scale factor.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.DpiInformation.ScaleY
Gets the y-axis scale factor.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton
**Summary:** Adds icon content to a standard button.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.EllipseDiameterProperty
Identifies the EllipseDiameter property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.EllipseStrokeThicknessProperty
Identifies the EllipseStrokeThickness property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconDataProperty
Identifies the IconData property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconHeightProperty
Identifies the IconHeight property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconWidthProperty
Identifies the IconWidth property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.EllipseDiameter
Gets or sets the ellipse diameter.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.EllipseStrokeThickness
Gets or sets the ellipse stroke thickness.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconData
Gets or sets the icon path data.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconHeight
Gets or sets the icon height.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernButton.IconWidth
Gets or sets the icon width.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog
**Summary:** Represents a Modern UI styled dialog window.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.BackgroundContentProperty
Identifies the BackgroundContent dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.ButtonsProperty
Identifies the Buttons dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.CloseCommand
Gets the close window command.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.OkButton
Gets the Ok button.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.CancelButton
Gets the Cancel button.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.YesButton
Gets the Yes button.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.NoButton
Gets the No button.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.CloseButton
Gets the Close button.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.BackgroundContent
Gets or sets the background content of this window instance.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.Buttons
Gets or sets the dialog buttons.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.MessageBoxResult
Gets the message box result.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernDialog.ShowMessage(System.String,System.String,System.Windows.MessageBoxButton,System.Windows.Window)
Displays a messagebox.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame
**Summary:** A simple content frame implementation with navigation support.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.KeepAliveProperty
Identifies the KeepAlive attached dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.KeepContentAliveProperty
Identifies the KeepContentAlive dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.ContentLoaderProperty
Identifies the ContentLoader dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.IsLoadingContentProperty
Identifies the IsLoadingContent dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.SourceProperty
Identifies the Source dependency property.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.FragmentNavigation
Occurs when navigation to a content fragment begins.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.Navigating
Occurs when a new navigation is requested.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.Navigated
Occurs when navigation to new content has completed.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.NavigationFailed
Occurs when navigation has failed.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.HandleRoutedEvent(System.Windows.Input.CanExecuteRoutedEventArgs)
Determines whether the routed event args should be handled.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.ShouldKeepContentAlive(System.Object)
Determines whether the specified content should be kept alive.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.GetKeepAlive(System.Windows.DependencyObject)
Gets a value indicating whether to keep specified object alive in a ModernFrame instance.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.SetKeepAlive(System.Windows.DependencyObject,System.Nullable{System.Boolean})
Sets a value indicating whether to keep specified object alive in a ModernFrame instance.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.KeepContentAlive
Gets or sets a value whether content should be kept in memory.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.ContentLoader
Gets or sets the content loader.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.IsLoadingContent
Gets a value indicating whether this instance is currently loading content.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernFrame.Source
Gets or sets the source of the current content.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu
**Summary:** Represents the menu in a Modern UI styled window.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.LinkGroupsProperty
Defines the LinkGroups dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedLinkGroupProperty
Defines the SelectedLinkGroup dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedLinkProperty
Defines the SelectedLink dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedSourceProperty
Defines the SelectedSource dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.VisibleLinkGroupsProperty
Defines the VisibleLinkGroups dependency property.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedSourceChanged
Occurs when the selected source has changed.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.LinkGroups
Gets or sets the link groups.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedLink
Gets or sets the selected link.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedSource
Gets or sets the source URI of the selected link.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.SelectedLinkGroup
Gets the selected link groups.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.VisibleLinkGroups
Gets the collection of link groups that are currently visible.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernMenu.GetGroupKey(BlueMonsterLabs.ModernUI.Presentation.LinkGroup)
Gets a non-null key for given group.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernProgressRing
**Summary:** Represents a control that indicates that an operation is ongoing.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernProgressRing.IsActiveProperty
Identifies the IsActive property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernProgressRing.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernProgressRing.OnApplyTemplate()
When overridden in a derived class, is invoked whenever application code or internal processes call .

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernProgressRing.IsActive
Gets or sets a value that indicates whether the is showing progress.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab
**Summary:** Represents a control that contains multiple pages that share the same space on screen.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.ContentLoaderProperty
Identifies the ContentLoader dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.LayoutProperty
Identifies the Layout dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.ListWidthProperty
Identifies the ListWidth dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.LinksProperty
Identifies the Links dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.SelectedSourceProperty
Identifies the SelectedSource dependency property.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.SelectedSourceChanged
Occurs when the selected source has changed.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.#ctor()
Initializes a new instance of the control.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.OnApplyTemplate()
When overridden in a derived class, is invoked whenever application code or internal processes call System.Windows.FrameworkElement.ApplyTemplate().

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.ContentLoader
Gets or sets the content loader.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.Layout
Gets or sets a value indicating how the tab should be rendered.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.Links
Gets or sets the collection of links that define the available content in this tab.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.ListWidth
Gets or sets the width of the list when Layout is set to List.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernTab.SelectedSource
Gets or sets the source URI of the selected link.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton
**Summary:** Adds icon content to a standard button.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.EllipseDiameterProperty
Identifies the EllipseDiameter property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.EllipseStrokeThicknessProperty
Identifies the EllipseStrokeThickness property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconDataProperty
Identifies the IconData property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconHeightProperty
Identifies the IconHeight property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconWidthProperty
Identifies the IconWidth property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.EllipseDiameter
Gets or sets the ellipse diameter.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.EllipseStrokeThickness
Gets or sets the ellipse stroke thickness.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconData
Gets or sets the icon path data.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconHeight
Gets or sets the icon height.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernToggleButton.IconWidth
Gets or sets the icon width.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow
**Summary:** Represents a Modern UI styled window.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.BackgroundContentProperty
Identifies the BackgroundContent dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.MenuLinkGroupsProperty
Identifies the MenuLinkGroups dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.TitleLinksProperty
Identifies the TitleLinks dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.IsTitleVisibleProperty
Identifies the IsTitleVisible dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.LogoDataProperty
Identifies the LogoData dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.ContentSourceProperty
Defines the ContentSource dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.ContentLoaderProperty
Identifies the ContentLoader dependency property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.LinkNavigatorProperty
Identifies the LinkNavigator dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.OnClosed(System.EventArgs)
Raises the System.Windows.Window.Closed event.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.OnApplyTemplate()
When overridden in a derived class, is invoked whenever application code or internal processes call System.Windows.FrameworkElement.ApplyTemplate().

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.BackgroundContent
Gets or sets the background content of this window instance.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.MenuLinkGroups
Gets or sets the collection of link groups shown in the window's menu.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.TitleLinks
Gets or sets the collection of links that appear in the menu in the title area of the window.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.IsTitleVisible
Gets or sets a value indicating whether the window title is visible in the UI.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.LogoData
Gets or sets the path data for the logo displayed in the title area of the window.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.ContentSource
Gets or sets the source uri of the current content.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.ContentLoader
Gets or sets the content loader.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.ModernWindow.LinkNavigator
Gets or sets the link navigator.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl
**Summary:** The platform does not currently support relative sized translation values. This primitive control walks through visual state animation storyboards and looks for identifying values to use as percentages.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.SimpleDoubleComparisonEpsilon
A simple Epsilon-style value used for trying to determine if a double has an identifying value.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl._knownWidth
The last known width of the control.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl._knownHeight
The last known height of the control.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl._specialAnimations
A set of custom animation adapters used to update the animation storyboards when the size of the control changes.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.#ctor()
Initializes a new instance of the RelativeAnimatingContentControl type.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.OnSizeChanged(System.Object,System.Windows.SizeChangedEventArgs)
Handles the size changed event.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.UpdateAnyAnimationValues()
Walks through the known storyboards in the control's template that may contain identifying values, storing them for future use and updates.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.UpdateKnownAnimations()
Walks through all special animations, updating based on the current size of the control.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.ProcessDoubleAnimationWithKeys(System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames)
Processes a double animation with keyframes, looking for known special values to store with an adapter.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.ProcessDoubleAnimation(System.Windows.Media.Animation.DoubleAnimation)
Processes a double animation looking for special values.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension
**Summary:** A selection of dimensions of interest for updating an animation.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension.Width
The width (horizontal) dimension.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension.Height
The height (vertical) dimension.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.AnimationValueAdapter
**Summary:** A simple class designed to store information about a specific animation instance and its properties. Able to update the values at runtime.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.AnimationValueAdapter.OriginalValue
Gets or sets the original double value.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.AnimationValueAdapter.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension)
Initializes a new instance of the AnimationValueAdapter type.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.AnimationValueAdapter.Dimension
Gets the dimension of interest for the control.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.AnimationValueAdapter.UpdateWithNewDimension(System.Double,System.Double)
Updates the original instance based on new dimension information from the control. Takes both and allows the subclass to make the decision on which ratio, values, and dimension to use.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.Instance
Stores the animation instance.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.GetValue()
Gets the value of the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.SetValue(System.Double)
Sets the value for the underlying property of interest.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.InitialValue
Gets the initial value (minus the identifying value portion) that the designer stored within the visual state animation property.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1._ratio
The ratio based on the original identifying value, used for computing the updated animation property of interest when the size of the control changes.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension,`0)
Initializes a new instance of the GeneralAnimationValueAdapter type.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.StripIdentifyingValueOff(System.Double)
Approximately removes the identifying value from a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.GetDimensionFromIdentifyingValue(System.Double)
Retrieves the dimension, if any, from the number. If the number does not have an identifying value, null is returned.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.UpdateWithNewDimension(System.Double,System.Double)
Updates the animation instance based on the dimensions of the control.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.GeneralAnimationValueAdapter`1.UpdateValue(System.Double)
Updates the value of the property.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationToAdapter
**Summary:** Adapter for DoubleAnimation's To property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationToAdapter.GetValue()
Gets the value of the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationToAdapter.SetValue(System.Double)
Sets the value for the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationToAdapter.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension,System.Windows.Media.Animation.DoubleAnimation)
Initializes a new instance of the DoubleAnimationToAdapter type.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFromAdapter
**Summary:** Adapter for DoubleAnimation's From property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFromAdapter.GetValue()
Gets the value of the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFromAdapter.SetValue(System.Double)
Sets the value for the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFromAdapter.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension,System.Windows.Media.Animation.DoubleAnimation)
Initializes a new instance of the DoubleAnimationFromAdapter type.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFrameAdapter
**Summary:** Adapter for double key frames.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFrameAdapter.GetValue()
Gets the value of the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFrameAdapter.SetValue(System.Double)
Sets the value for the underlying property of interest.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationFrameAdapter.#ctor(BlueMonsterLabs.ModernUI.Windows.Controls.RelativeAnimatingContentControl.DoubleAnimationDimension,System.Windows.Media.Animation.DoubleKeyFrame)
Initializes a new instance of the DoubleAnimationFrameAdapter type.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.SourceEventArgs
**Summary:** Provides data for events related to uri sources.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.SourceEventArgs.#ctor(System.Uri)
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.SourceEventArgs.Source
Gets the source uri.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.TabLayout
**Summary:** Define the available tab layouts.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TabLayout.Tab
Tab layout.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TabLayout.List
List layout.

## Type: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl
**Summary:** Represents a control with a single piece of content and when that content changes performs a transition animation.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.PresentationGroup
The name of the group that holds the presentation states.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.NormalState
The name of the state that represents a normal situation where no transition is currently being used.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.DefaultTransitionState
The name of the state that represents the default transition.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.PreviousContentPresentationSitePartName
The name of the control that will display the previous content.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.CurrentContentPresentationSitePartName
The name of the control that will display the current content.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.CurrentContentPresentationSite
Gets or sets the current content presentation site.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.PreviousContentPresentationSite
Gets or sets the previous content presentation site.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.IsTransitioningChanged
Occurs when the IsTransitioning value has changed.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl._allowIsTransitioningWrite
Indicates whether the control allows writing IsTransitioning.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.IsTransitioning
Gets a value indicating whether this instance is currently performing a transition.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.IsTransitioningProperty
Identifies the IsTransitioning dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnIsTransitioningPropertyChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)
IsTransitioningProperty property changed handler.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl._currentTransition
The storyboard that is used to transition old and new content.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.CurrentTransition
Gets or sets the storyboard that is used to transition old and new content.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.Transition
Gets or sets the name of the transition to use. These correspond directly to the VisualStates inside the PresentationStates group.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.TransitionProperty
Identifies the Transition dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnTransitionPropertyChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)
TransitionProperty property changed handler.

### Property: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.RestartTransitionOnContentChange
Gets or sets a value indicating whether the current transition will be aborted when setting new content during a transition.

### Field: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.RestartTransitionOnContentChangeProperty
Identifies the RestartTransitionOnContentChange dependency property.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnRestartTransitionOnContentChangePropertyChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)
RestartTransitionOnContentChangeProperty property changed handler.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnRestartTransitionOnContentChangeChanged(System.Boolean,System.Boolean)
Called when the RestartTransitionOnContentChangeProperty changes.

### Event: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.TransitionCompleted
Occurs when the current transition has completed.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.#cctor()
Static constructor

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.#ctor()
Initializes a new instance of the class.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnApplyTemplate()
Builds the visual tree for the TransitioningContentControl control when a new template is applied.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnContentChanged(System.Object,System.Object)
Called when the value of the property changes.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.StartTransition(System.Object,System.Object)
Starts the transition.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.OnTransitionCompleted(System.Object,System.EventArgs)
Handles the Completed event of the transition storyboard.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.AbortTransition()
Aborts the transition and releases the previous content.

### Method: BlueMonsterLabs.ModernUI.Windows.Controls.TransitioningContentControl.GetStoryboard(System.String)
Attempts to find a storyboard that matches the newTransition name.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToFontWeightConverter
**Summary:** Converts a boolean value to a font weight (false: normal, true: bold)

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToFontWeightConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToFontWeightConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToVisibilityConverter
**Summary:** Converts boolean to visibility values.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.BooleanToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.NullOrEmptyStringToVisibilityConverter
**Summary:** Converts a null or empty string value to Visibility.Visible and any other value to Visibility.Collapsed

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.NullOrEmptyStringToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.NullOrEmptyStringToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.NullToVisibilityConverter
**Summary:** Converts a null value to Visibility.Visible and any other value to Visibility.Collapsed

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.NullToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.NullToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.ToLowerConverter
**Summary:** Converts string values to lower case.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.ToLowerConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.ToLowerConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.Converters.ToUpperConverter
**Summary:** Converts string values to upper case.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.ToUpperConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

### Method: BlueMonsterLabs.ModernUI.Windows.Converters.ToUpperConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)
Converts a value.

## Type: BlueMonsterLabs.ModernUI.Windows.DefaultContentLoader
**Summary:** Loads XAML files using Application.LoadComponent.

### Method: BlueMonsterLabs.ModernUI.Windows.DefaultContentLoader.LoadContentAsync(System.Uri,System.Threading.CancellationToken)
Asynchronously loads content from specified uri.

### Method: BlueMonsterLabs.ModernUI.Windows.DefaultContentLoader.LoadContent(System.Uri)
Loads the content from specified uri.

## Type: BlueMonsterLabs.ModernUI.Windows.IContent
**Summary:** Defines the optional contract for content loaded in a ModernFrame.

### Method: BlueMonsterLabs.ModernUI.Windows.IContent.OnFragmentNavigation(BlueMonsterLabs.ModernUI.Windows.Navigation.FragmentNavigationEventArgs)
Called when navigation to a content fragment begins.

### Method: BlueMonsterLabs.ModernUI.Windows.IContent.OnNavigatedFrom(BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationEventArgs)
Called when this instance is no longer the active content in a frame.

### Method: BlueMonsterLabs.ModernUI.Windows.IContent.OnNavigatedTo(BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationEventArgs)
Called when a this instance becomes the active content in a frame.

### Method: BlueMonsterLabs.ModernUI.Windows.IContent.OnNavigatingFrom(BlueMonsterLabs.ModernUI.Windows.Navigation.NavigatingCancelEventArgs)
Called just before this instance is no longer the active content in a frame.

## Type: BlueMonsterLabs.ModernUI.Windows.IContentLoader
**Summary:** The contract for loading content.

### Method: BlueMonsterLabs.ModernUI.Windows.IContentLoader.LoadContentAsync(System.Uri,System.Threading.CancellationToken)
Asynchronously loads content from specified uri.

## Type: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx
**Summary:** Provides addition visual tree helper methods.

### Method: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx.TryGetVisualStateGroup(System.Windows.DependencyObject,System.String)
Gets specified visual state group.

### Method: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx.GetImplementationRoot(System.Windows.DependencyObject)
Gets the implementation root.

### Method: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx.Ancestors(System.Windows.DependencyObject)
Returns a collection of the visual ancestor elements of specified dependency object.

### Method: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx.AncestorsAndSelf(System.Windows.DependencyObject)
Returns a collection of visual elements that contain specified object, and the ancestors of specified object.

### Method: BlueMonsterLabs.ModernUI.Windows.Media.VisualTreeHelperEx.GetParent(System.Windows.DependencyObject)
Gets the parent for specified dependency object.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.DefaultLinkNavigator
**Summary:** The default link navigator with support for loading frame content, external link navigation using the default browser and command execution.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.DefaultLinkNavigator.#ctor()
Initializes a new instance of the class.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.DefaultLinkNavigator.ExternalSchemes
Gets or sets the schemes for external link navigation.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.DefaultLinkNavigator.Commands
Gets or sets the navigable commands.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.DefaultLinkNavigator.Navigate(System.Uri,System.Windows.FrameworkElement,System.String)
Performs navigation to specified link.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.FragmentNavigationEventArgs
**Summary:** Provides data for fragment navigation events.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.FragmentNavigationEventArgs.Fragment
Gets the uniform resource identifier (URI) fragment.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.ILinkNavigator
**Summary:** The hyperlink navigator contract.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.ILinkNavigator.Commands
Gets or sets the navigable commands.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.ILinkNavigator.Navigate(System.Uri,System.Windows.FrameworkElement,System.String)
Performs navigation to specified link.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.LinkCommands
**Summary:** The routed link commands.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.LinkCommands.NavigateLink
Gets the navigate link routed command.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigatingCancelEventArgs
**Summary:** Provides data for the method and the event.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigatingCancelEventArgs.IsParentFrameNavigating
Gets a value indicating whether the frame performing the navigation is a parent frame or the frame itself.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigatingCancelEventArgs.NavigationType
Gets a value that indicates the type of navigation that is occurring.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigatingCancelEventArgs.Cancel
Gets or sets a value indicating whether the event should be canceled.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationBaseEventArgs
**Summary:** Defines the base navigation event arguments.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationBaseEventArgs.Frame
Gets the frame that raised this event.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationBaseEventArgs.Source
Gets the source uri for the target being navigated to.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationEventArgs
**Summary:** Provides data for frame navigation events.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationEventArgs.NavigationType
Gets a value that indicates the type of navigation that is occurring.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationEventArgs.Content
Gets the content of the target being navigated to.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationFailedEventArgs
**Summary:** Provides data for the event.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationFailedEventArgs.Error
Gets the error from the failed navigation.

### Property: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationFailedEventArgs.Handled
Gets or sets a value that indicates whether the failure event has been handled.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper
**Summary:** Provides helper function for navigation.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.FrameSelf
Identifies the current frame.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.FrameTop
Identifies the top frame.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.FrameParent
Identifies the parent of the current frame.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.FindFrame(System.String,System.Windows.FrameworkElement)
Finds the frame identified with given name in the specified context.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.RemoveFragment(System.Uri)
Removes the fragment from specified uri and return it.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.RemoveFragment(System.Uri,System.String@)
Removes the fragment from specified uri and returns the uri without the fragment and the fragment itself.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.ToUri(System.Object)
Tries to cast specified value to a uri. Either a uri or string input is accepted.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.TryParseUriWithParameters(System.Object,System.Uri@,System.String@,System.String@)
Tries to parse a uri with parameters from given value.

### Method: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationHelper.TryParseUriWithParameters(System.String,System.Uri@,System.String@,System.String@)
Tries to parse a uri with parameters from given string value.

## Type: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationType
**Summary:** Identifies the types of navigation that are supported.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationType.New
Navigating to new content.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationType.Back
Navigating back in the back navigation history.

### Field: BlueMonsterLabs.ModernUI.Windows.Navigation.NavigationType.Refresh
Reloading the current content.


