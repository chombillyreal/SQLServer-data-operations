// Showing data in dataGridView
DbyourdatasourceEntities db = new DbyourdatasourceEntities();
 try
 {
   SqlConnection bag = new SqlConnection(@"Data Source=WINDOWS-NLM6BJU\SQL2022;Initial Catalog=Dbkullanicilar;Integrated Security=True");
   SqlCommand listele = new SqlCommand("Select * From tblkullanicilar", bag);
   SqlDataAdapter da = new SqlDataAdapter(listele);
   DataTable dt = new DataTable();
  da.Fill(dt);
   dataGridView1.DataSource = dt;
}        
catch(Exception sa)
 {
   MessageBox.Show(sa.Message);
 }
 
 //Adding Data
 
 try
{
  YOURTABLENAME t = new YOURTABLENAME();
   t.NAME = textBox2.Text;
   t.LASTNAME = textBox3.Text;
   db.YOURTABLENAME.Add(t);
   db.SaveChanges();
   MessageBox.Show("Successfully completed."); 
   }
catch(Exception sa)
 {
   MessageBox.Show(sa.Message);
 }
 
 //Update Data
try
{
   int id = Convert.ToInt32(textBox1.Text);
   var z = db.YOURTABLENAME.Find(id);
   z.NAME = textBox2.Text;
   z.LASTNAME = textBox3.Text;
   db.SaveChanges();
   MessageBox.Show("Successfully completed.");
}
catch(Exception sa)
{
   MessageBox.Show(sa.Message);
}

// Data deletion
try
   {
     int id = Convert.ToInt32(textBox1.Text);
     var x = db.YOURTABLENAME.Find(id);
     db.YOURTABLENAME.Remove(x);
     db.SaveChanges();
     MessageBox.Show("Succesfully completed.");
}
catch (Exception sa)
 {
  MessageBox.Show(sa.Message);
 }
