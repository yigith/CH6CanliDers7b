using Npgsql;

var cs = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=hafta7db";

// OgrenciEkle("Burak Özkan", "e", 2001);
// OgrenciSil(3);
// AdGuncelle(5, "Muhtar Hamit");
Listele();

void AdGuncelle(int id, string ad)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand("UPDATE ogrenciler SET ad = @ad WHERE id = @id", con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@ad", ad);
        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
    }
}

void OgrenciSil(int id)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand("DELETE FROM ogrenciler WHERE id = @id", con);
        cmd.Parameters.AddWithValue("@id", id);
        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
    }
}

void OgrenciEkle(string ad, string cinsiyet, int dogumYili)
{
    using (var con = new NpgsqlConnection(cs))
    {
        con.Open();
        var cmd = new NpgsqlCommand("INSERT INTO ogrenciler(ad, cinsiyet, dogum_yili) VALUES(@p1, @p2, @p3);", con);
        cmd.Parameters.AddWithValue("@p1", ad);
        cmd.Parameters.AddWithValue("@p2", cinsiyet);
        cmd.Parameters.AddWithValue("@p3", dogumYili);
        int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
    }
}

void Listele()
{
    // 1. BAĞLANTI KUR ve BAĞLANTIYI AÇ
    NpgsqlConnection con = new NpgsqlConnection(cs);
    con.Open();
    //Console.WriteLine(con.State);

    // 2. KOMUTU OLUŞTUR
    NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM ogrenciler ORDER BY id", con);

    // 3. KOMUTU ÇALIŞTIR VE VERİ OKUYUCU OLUŞTUR
    NpgsqlDataReader dr = cmd.ExecuteReader();

    // 4. SATIR SATIR OKU VE YAZDIR
    Console.WriteLine("{0,2} {1,-20} {2,-2} {3}", "#", "Öğrencinin Adı", "C", "D. Yılı");
    while (dr.Read())
    {
        Console.WriteLine("{0,2} {1,-20} {2,-2} {3}", dr["id"], dr["ad"], dr["cinsiyet"], dr["dogum_yili"]);
    }

    // 5. OKUYUCUYU VE BAĞLANTIYI KAPAT
    dr.Close();
    con.Close();
}


Console.ReadKey();