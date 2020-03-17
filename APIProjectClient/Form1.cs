using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIProjectClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnExecute_ClickAsync(object sender, EventArgs e)
        {
            var target = comboBoxTarget.SelectedItem;
            var method = comboBoxMethod.SelectedItem;

            var requestUrl = txbRequestUrl.Text.ToString();

            if (method == null) {
                MessageBox.Show("Please Select a Method !");
            }else if (target == null)
            {
                MessageBox.Show("Please Select a Target !");
            /*
            }else if ("".Equals(requestUrl)) {

                MessageBox.Show("Please Enter Request URL !");
            */
            }else
            {
                //MessageBox.Show(method.ToString() + " >>> " + requestUrl);
                await RunAsync(target.ToString(), method.ToString(), requestUrl);
            }
        }


        private async Task RunAsync(string target, string method, string requestUrl)
        {
            HttpClient client = new HttpClient();

            // Add apikey as header so hide apikey parameter
            // string key = "?apikey=PdTcA57za03FI6QwsetS6kLs4HOjY3ea";
            client.DefaultRequestHeaders.Add("apikey", "PdTcA57za03FI6QwsetS6kLs4HOjY3ea");

            client.BaseAddress = new Uri("https://jangysseul-eval-prod.apigee.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            try
            {
                string json;
                //string result = "/schoolapi/api/" + requestUrl + key;
                string result = "/schoolapi/api/";// + requestUrl;

                
                if ("PublicSchool".Equals(target))
                {
                    result += "publicschool/";
                }
                else if ("PrivateSchool".Equals(target))
                {
                    result += "privateschool/";
                }
                else if ("PrivateSchoolRate".Equals(target))
                {
                    if ("GET".Equals(method)&&"".Equals(requestUrl))
                    {
                        result += "privateschool/privateschoolrate/";
                    }
                    else
                    {
                        result += "privateschool/";
                    }
                }
                else if ("EnrolmentByGender".Equals(target))
                {
                    result += "EnrolmentByGender/";
                }
                else if ("EnrolmentBySchool".Equals(target))
                {
                    result += "EnrolmentBySchool/";
                }
                result += requestUrl;

                //MessageBox.Show("result >> " + result);

                // GET method
                if ("GET".Equals(method))
                {
                    lstbResponse.Items.Clear();
                    HttpResponseMessage response = await client.GetAsync(result);
                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();

                        if ("PublicSchool".Equals(target))
                        {
                            try
                            {

                                IEnumerable<PublicSchool> schools = JsonConvert.DeserializeObject<IEnumerable<PublicSchool>>(json);
                                foreach (PublicSchool school in schools)
                                {
                                    lstbResponse.Items.Add(school.ToString());
                                }
                            }
                            catch
                            {
                                PublicSchool school = JsonConvert.DeserializeObject<PublicSchool>(json);
                                lstbResponse.Items.Add(school.ToString());
                            }

                        }
                        else if ("PrivateSchool".Equals(target))
                        {
                            try
                            {
                                IEnumerable<PrivateSchool> schools = JsonConvert.DeserializeObject<IEnumerable<PrivateSchool>>(json);

                                foreach (PrivateSchool school in schools)
                                {
                                    lstbResponse.Items.Add(school.ToString());
                                }
                            }
                            catch
                            {
                                PrivateSchool school = JsonConvert.DeserializeObject<PrivateSchool>(json);
                                lstbResponse.Items.Add(school.ToString());
                            }
                        }
                        else if ("PrivateSchoolRate".Equals(target))
                        {
                            try
                            {
                                IEnumerable<PrivateSchoolRate> rates = JsonConvert.DeserializeObject<IEnumerable<PrivateSchoolRate>>(json);
                                foreach (PrivateSchoolRate rate in rates)
                                {
                                    lstbResponse.Items.Add(rate.ToString());
                                }
                            }
                            catch
                            {
                                PrivateSchoolRate rate = JsonConvert.DeserializeObject<PrivateSchoolRate>(json);
                                lstbResponse.Items.Add(rate.ToString());
                            }
                        }
                        else if ("EnrolmentByGender".Equals(target))
                        {
                            try
                            {
                                IEnumerable<EnrolmentByGender> enrolments = JsonConvert.DeserializeObject<IEnumerable<EnrolmentByGender>>(json);
                                foreach (EnrolmentByGender enrolment in enrolments)
                                {
                                    lstbResponse.Items.Add(enrolment.ToString());
                                }
                            }
                            catch
                            {
                                EnrolmentByGender enrolment = JsonConvert.DeserializeObject<EnrolmentByGender>(json);
                                lstbResponse.Items.Add(enrolment.ToString());
                            }

                        }
                        else if ("EnrolmentBySchool".Equals(target))
                        {
                            try
                            {
                                IEnumerable<EnrolmentBySchool> enrolments = JsonConvert.DeserializeObject<IEnumerable<EnrolmentBySchool>>(json);
                                foreach (EnrolmentBySchool enrolment in enrolments)
                                {
                                    lstbResponse.Items.Add(enrolment.ToString());
                                }
                            }
                            catch
                            {
                                EnrolmentBySchool enrolment = JsonConvert.DeserializeObject<EnrolmentBySchool>(json);
                                lstbResponse.Items.Add(enrolment.ToString());

                            }
                        }
                    }
                    else
                    {
                        lstbResponse.Items.Add("Internal Server error");
                    }
                }
                
                // POST method only for PrivateSchoolRate
                else if ("POST".Equals(method))
                {
                    if ("PrivateSchoolRate".Equals(target))
                    {
                        lstbResponse.Items.Clear();
                        json = txbJson.Text.ToString();
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(result, content);

                        if (HttpStatusCode.Created == response.StatusCode)
                        {
                            lstbResponse.Items.Add("SUCCESS: You successfully saved your rate for Private School");
                        }
                        else
                        {
                            lstbResponse.Items.Add("ERROR: You failed to save !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only >>PrivateSchoolRate<< access POST method");
                    }

                }

                // PUI method only for PrivateSchoolRate
                else if ("PUT".Equals(method))
                {

                    lstbResponse.Items.Clear();
                    json = txbJson.Text.ToString();
                    StringContent changecontent = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(result, changecontent);

                    if (response.IsSuccessStatusCode)
                    {
                        lstbResponse.Items.Add("SUCCESS: You successfully updated it for Private School");
                    }
                    else
                    {
                        lstbResponse.Items.Add("ERROR: You failed to update !");
                    }
                }

                // DELETE method only for PrivateSchoolRate
                else if ("DELETE".Equals(method))
                {

                    if ("PrivateSchoolRate".Equals(target))
                    {
                        lstbResponse.Items.Clear();
                        HttpResponseMessage response = await client.DeleteAsync(result);

                        if (response.IsSuccessStatusCode)
                        {
                            lstbResponse.Items.Add("SUCCESS: You successfully deleted it for Private School");
                        }
                        else
                        {
                            lstbResponse.Items.Add("ERROR: You failed to delete !");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Only >>PrivateSchoolRate<< access DELETE method");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
