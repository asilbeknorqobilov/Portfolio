namespace Topshiriq;

public struct Ratsional
{
    public int surat;
    public int mahraj;

    public Ratsional(int surat, int mahraj)
    {
        this.surat = surat;
        this.mahraj = mahraj;
    }

    // EKUB
    public static int EKUB(int surat, int mahraj)
    {
        int nat = 1;
        while (surat != mahraj)
        {
            if (surat > mahraj)
            {
                surat = surat - mahraj;
                nat = surat;
            }

            else
            {
                mahraj = mahraj - surat;
                nat = mahraj;
            }
        }
            if (surat == mahraj)
            {
                nat = surat;
            }

        return nat;
    }


    public Ratsional Qisqartir()
    {
        int ekub = EKUB(surat, mahraj);
        int s = surat / ekub;
        int m = mahraj / ekub;
        Ratsional nat = new Ratsional(s, m);
        return nat;
    }
    
    public static Ratsional operator +(Ratsional x, Ratsional y)
    {
        Butun_sonlar bs = new Butun_sonlar(x.mahraj, y.mahraj);
        int ekuk = bs.Ekuk();
        int k = ekuk;
        int xs = x.surat * (ekuk / x.mahraj);
        int ys = y.surat * (ekuk / y.mahraj);
        int s = xs + ys;
        Ratsional res = new Ratsional(s, ekuk);
        return res;
    }

    public bool Equals(Ratsional y)
    {
        return this.surat * y.mahraj == this.mahraj * y.surat;
    }

    public bool kichik(Ratsional x)
    {
        Butun_sonlar bs = new Butun_sonlar(this.mahraj, x.mahraj);
        int ekuk = bs.Ekuk();
        int ts = this.surat * (ekuk / this.mahraj);
        int xs = x.surat * (ekuk / x.mahraj);
        return ts < xs;
    }


    public override string ToString()
    {
        return String.Format("{0}/{1}", surat, mahraj);
    }
}               
