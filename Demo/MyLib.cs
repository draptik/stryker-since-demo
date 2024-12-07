namespace Demo;

public static class MyLib
{
    public static string DoMagic(int age) =>
        age < 18
            ? "child"
            : "adult";
}