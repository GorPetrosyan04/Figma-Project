namespace Google_Tv_App.Components;

public partial class Contents : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(Contents), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (Contents)bindable;
    });

    public Contents()
    {
        InitializeComponent();
        Button1.Focused += Button1_Focused;
        Button1.Unfocused += Button1_Unfocused;
    }

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    private void Button1_Unfocused(object sender, FocusEventArgs e)
    {
        Border1.StrokeThickness = 0;
        Border1.ScaleTo(1, 100);
    }

    private void Button1_Focused(object sender, FocusEventArgs e)
    {
        Border1.StrokeThickness = 3;
        Border1.ScaleTo(1.1, 100);
    }
}
