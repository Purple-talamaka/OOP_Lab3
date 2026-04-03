using System;
using System.IO;

public class Model
{
    private int _a;
    private int _b;
    private int _c;

    public int A
    {
        get { return _a; }
    }

    public int B
    {
        get { return _b; }
    }

    public int C
    {
        get { return _c; }
    }

    // Устанавливает A в диапазоне 0-100. Если B < A, подтягивает B до A.
    // Если после этого C < B, подтягивает C до B.
    public void SetA(int value)
    {
        value = Math.Clamp(value, 0, 100);
        _a = value;

        if (_b < _a)
        {
            _b = _a;
        }

        if (_c < _b)
        {
            _c = _b;
        }
        Save();
    }

    // Устанавливает B в диапазоне от A до C. Если значение выходит за
    // пределы — зажимается до ближайшей границы.
    public void SetB(int value)
    {
        value = Math.Clamp(value, _a, _c);
        _b = value;
        Save();
    }

    // Устанавливает C в диапазоне 0-100. Если B > C, подтягивает B до C.
    // Если после этого A > B, подтягивает A до B.
    public void SetC(int value)
    {
        value = Math.Clamp(value, 0, 100);
        _c = value;

        if (_b > _c)
        {
            _b = _c;
        }

        if (_a > _b)
        {
            _a = _b;
        }
        Save();
    }

    // Метод для сохранения данных в файл
    private void Save()
    {
        File.WriteAllText("data.txt", $"{_a},{_b},{_c}");
    }

    // Метод для загрузки данных из файла
    public void Load()
    {
        if (!File.Exists("data.txt")) return;
        var parts = File.ReadAllText("data.txt").Split(',');
        if (parts.Length != 3) return;
        _a = int.Parse(parts[0]);
        _b = int.Parse(parts[1]);
        _c = int.Parse(parts[2]);
    }
}

