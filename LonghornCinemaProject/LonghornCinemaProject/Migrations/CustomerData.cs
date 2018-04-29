using LonghornCinemaProject.Models;
using LonghornCinemaProject.DAL;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LonghornCinemaProject.Migrations
{
	public class CustomerData
	{
		public void SeedCustomers(AppDbContext db)
		{
			Customer r1 = new Customer();
			r1.Password = "hello1";
			r1.LastName = "Baker";
			r1.FirstName = "Christopher";
			r1.MiddleInitial = "L.";
			r1.ZipCode = 78705;
			r1.City = "Austin";
			r1.State = "TX";
			r1.Street = "1245 Lake Anchorage Blvd.";
			r1.SSN = 9075571146;
			r1.PhoneNumber = 5125550180;
			r1.Email = "cbaker@example.com";
			r1.PopcornPoints = 110;
			r1.BirthDate = new DateTime(11/23/1949);
			r1.CustomerID = 5001;
			db.Customers.AddOrUpdate(r => r.SSN, r1);
			db.SaveChanges();

			Customer r2 = new Customer();
			r2.Password = "potato";
			r2.LastName = "Banks";
			r2.FirstName = "Michelle";
			r2.MiddleInitial = "";
			r2.ZipCode = 78712;
			r2.City = "Austin";
			r2.State = "TX";
			r2.Street = "1300 Tall Pine Lane";
			r2.SSN = 9042678873;
			r2.PhoneNumber = 5125550183;
			r2.Email = "banker@longhorn.net";
			r2.PopcornPoints = 40;
			r2.BirthDate = new DateTime(11/27/1962);
			r2.CustomerID = 5002;
			db.Customers.AddOrUpdate(r => r.SSN, r2);
			db.SaveChanges();

			Customer r3 = new Customer();
			r3.Password = "painting";
			r3.LastName = "Broccolo";
			r3.FirstName = "Franco";
			r3.MiddleInitial = "V";
			r3.ZipCode = 78704;
			r3.City = "Austin";
			r3.State = "TX";
			r3.Street = "62 Browning Road";
			r3.SSN = 4155659699;
			r3.PhoneNumber = 5125550128;
			r3.Email = "franco@example.com";
			r3.PopcornPoints = 30;
			r3.BirthDate = new DateTime(10/11/1992);
			r3.CustomerID = 5003;
			db.Customers.AddOrUpdate(r => r.SSN, r3);
			db.SaveChanges();

			Customer r4 = new Customer();
			r4.Password = "texas1";
			r4.LastName = "Chang";
			r4.FirstName = "Wendy";
			r4.MiddleInitial = "L";
			r4.ZipCode = 78681;
			r4.City = "Round Rock";
			r4.State = "TX";
			r4.Street = "202 Bellmont Hall";
			r4.SSN = 9075943222;
			r4.PhoneNumber = 5125550133;
			r4.Email = "wchang@example.com";
			r4.PopcornPoints = 0;
			r4.BirthDate = new DateTime(5/16/1997);
			r4.CustomerID = 5004;
			db.Customers.AddOrUpdate(r => r.SSN, r4);
			db.SaveChanges();

			Customer r5 = new Customer();
			r5.Password = "Anchorage";
			r5.LastName = "Chou";
			r5.FirstName = "Lim";
			r5.MiddleInitial = "";
			r5.ZipCode = 78705;
			r5.City = "Austin";
			r5.State = "TX";
			r5.Street = "1600 Teresa Lane";
			r5.SSN = 8137724599;
			r5.PhoneNumber = 5125550102;
			r5.Email = "limchou@gogle.com";
			r5.PopcornPoints = 40;
			r5.BirthDate = new DateTime(4/6/1970);
			r5.CustomerID = 5005;
			db.Customers.AddOrUpdate(r => r.SSN, r5);
			db.SaveChanges();

			Customer r6 = new Customer();
			r6.Password = "pepperoni";
			r6.LastName = "Dixon";
			r6.FirstName = "Shan";
			r6.MiddleInitial = "D";
			r6.ZipCode = 78712;
			r6.City = "Austin";
			r6.State = "TX";
			r6.Street = "234 Holston Circle";
			r6.SSN = 2052643255;
			r6.PhoneNumber = 5125550146;
			r6.Email = "shdixon@aoll.com";
			r6.PopcornPoints = 20;
			r6.BirthDate = new DateTime(1/12/1984);
			r6.CustomerID = 5006;
			db.Customers.AddOrUpdate(r => r.SSN, r6);
			db.SaveChanges();

			Customer r7 = new Customer();
			r7.Password = "longhorns";
			r7.LastName = "Evans";
			r7.FirstName = "Jim Bob";
			r7.MiddleInitial = "";
			r7.ZipCode = 78628;
			r7.City = "Georgetown";
			r7.State = "TX";
			r7.Street = "506 Farrell Circle";
			r7.SSN = 2102565834;
			r7.PhoneNumber = 5125550170;
			r7.Email = "j.b.evans@aheca.org";
			r7.PopcornPoints = 50;
			r7.BirthDate = new DateTime(9/9/1959);
			r7.CustomerID = 5007;
			db.Customers.AddOrUpdate(r => r.SSN, r7);
			db.SaveChanges();

			Customer r8 = new Customer();
			r8.Password = "aggies";
			r8.LastName = "Feeley";
			r8.FirstName = "Lou Ann";
			r8.MiddleInitial = "K";
			r8.ZipCode = 78746;
			r8.City = "Austin";
			r8.State = "TX";
			r8.Street = "600 S 8th Street W";
			r8.SSN = 4062556749;
			r8.PhoneNumber = 5125550105;
			r8.Email = "feeley@penguin.org";
			r8.PopcornPoints = 170;
			r8.BirthDate = new DateTime(1/12/2001);
			r8.CustomerID = 5008;
			db.Customers.AddOrUpdate(r => r.SSN, r8);
			db.SaveChanges();

			Customer r9 = new Customer();
			r9.Password = "raiders";
			r9.LastName = "Freeley";
			r9.FirstName = "Tesa";
			r9.MiddleInitial = "P";
			r9.ZipCode = 78657;
			r9.City = "Horseshoe Bay";
			r9.State = "TX";
			r9.Street = "4448 Fairview Ave.";
			r9.SSN = 6123255687;
			r9.PhoneNumber = 5125550114;
			r9.Email = "tfreeley@minnetonka.ci.us";
			r9.PopcornPoints = 160;
			r9.BirthDate = new DateTime(2/4/1991);
			r9.CustomerID = 5009;
			db.Customers.AddOrUpdate(r => r.SSN, r9);
			db.SaveChanges();

			Customer r10 = new Customer();
			r10.Password = "mustangs";
			r10.LastName = "Garcia";
			r10.FirstName = "Margaret";
			r10.MiddleInitial = "L";
			r10.ZipCode = 78727;
			r10.City = "Austin";
			r10.State = "TX";
			r10.Street = "594 Longview";
			r10.SSN = 4066593544;
			r10.PhoneNumber = 5125550155;
			r10.Email = "mgarcia@gogle.com";
			r10.PopcornPoints = 10;
			r10.BirthDate = new DateTime(10/2/1991);
			r10.CustomerID = 5010;
			db.Customers.AddOrUpdate(r => r.SSN, r10);
			db.SaveChanges();

			Customer r11 = new Customer();
			r11.Password = "onetime";
			r11.LastName = "Haley";
			r11.FirstName = "Charles";
			r11.MiddleInitial = "E";
			r11.ZipCode = 78712;
			r11.City = "Austin";
			r11.State = "TX";
			r11.Street = "One Cowboy Pkwy";
			r11.SSN = 2148475583;
			r11.PhoneNumber = 5125550116;
			r11.Email = "chaley@thug.com";
			r11.PopcornPoints = 40;
			r11.BirthDate = new DateTime(7/10/1974);
			r11.CustomerID = 5011;
			db.Customers.AddOrUpdate(r => r.SSN, r11);
			db.SaveChanges();

			Customer r12 = new Customer();
			r12.Password = "hampton1";
			r12.LastName = "Hampton";
			r12.FirstName = "Jeffrey";
			r12.MiddleInitial = "T.";
			r12.ZipCode = 78666;
			r12.City = "San Marcos";
			r12.State = "TX";
			r12.Street = "337 38th St.";
			r12.SSN = 9076978613;
			r12.PhoneNumber = 5125550150;
			r12.Email = "jeffh@sonic.com";
			r12.PopcornPoints = 150;
			r12.BirthDate = new DateTime(3/10/2004);
			r12.CustomerID = 5012;
			db.Customers.AddOrUpdate(r => r.SSN, r12);
			db.SaveChanges();

			Customer r13 = new Customer();
			r13.Password = "jhearn22";
			r13.LastName = "Hearn";
			r13.FirstName = "John";
			r13.MiddleInitial = "B";
			r13.ZipCode = 78705;
			r13.City = "Austin";
			r13.State = "TX";
			r13.Street = "4225 North First";
			r13.SSN = 5208965621;
			r13.PhoneNumber = 5125550196;
			r13.Email = "wjhearniii@umich.org";
			r13.PopcornPoints = 0;
			r13.BirthDate = new DateTime(8/5/1950);
			r13.CustomerID = 5013;
			db.Customers.AddOrUpdate(r => r.SSN, r13);
			db.SaveChanges();

			Customer r14 = new Customer();
			r14.Password = "hickhickup";
			r14.LastName = "Hicks";
			r14.FirstName = "Anthony";
			r14.MiddleInitial = "J";
			r14.ZipCode = 78712;
			r14.City = "Austin";
			r14.State = "TX";
			r14.Street = "32 NE Garden Ln., Ste 910";
			r14.SSN = 7355788965;
			r14.PhoneNumber = 5125550188;
			r14.Email = "ahick@yaho.com";
			r14.PopcornPoints = 60;
			r14.BirthDate = new DateTime(12/8/2004);
			r14.CustomerID = 5014;
			db.Customers.AddOrUpdate(r => r.SSN, r14);
			db.SaveChanges();

			Customer r15 = new Customer();
			r15.Password = "ingram2015";
			r15.LastName = "Ingram";
			r15.FirstName = "Brad";
			r15.MiddleInitial = "S.";
			r15.ZipCode = 10101;
			r15.City = "New York";
			r15.State = "NY";
			r15.Street = "6548 La Posada Ct.";
			r15.SSN = 9074678821;
			r15.PhoneNumber = 5125550116;
			r15.Email = "ingram@jack.com";
			r15.PopcornPoints = 20;
			r15.BirthDate = new DateTime(9/5/2001);
			r15.CustomerID = 5015;
			db.Customers.AddOrUpdate(r => r.SSN, r15);
			db.SaveChanges();

			Customer r16 = new Customer();
			r16.Password = "toddy25";
			r16.LastName = "Jacobs";
			r16.FirstName = "Todd";
			r16.MiddleInitial = "L.";
			r16.ZipCode = 78729;
			r16.City = "Austin";
			r16.State = "TX";
			r16.Street = "4564 Elm St.";
			r16.SSN = 9074653365;
			r16.PhoneNumber = 5125550166;
			r16.Email = "toddj@yourmom.com";
			r16.PopcornPoints = 170;
			r16.BirthDate = new DateTime(1/20/1999);
			r16.CustomerID = 5016;
			db.Customers.AddOrUpdate(r => r.SSN, r16);
			db.SaveChanges();

			Customer r17 = new Customer();
			r17.Password = "something";
			r17.LastName = "Lawrence";
			r17.FirstName = "Victoria";
			r17.MiddleInitial = "M.";
			r17.ZipCode = 90210;
			r17.City = "Beverly Hills";
			r17.State = "CA";
			r17.Street = "6639 Butterfly Ln.";
			r17.SSN = 9079457399;
			r17.PhoneNumber = 5125550173;
			r17.Email = "thequeen@aska.net";
			r17.PopcornPoints = 130;
			r17.BirthDate = new DateTime(4/14/2000);
			r17.CustomerID = 5017;
			db.Customers.AddOrUpdate(r => r.SSN, r17);
			db.SaveChanges();

			Customer r18 = new Customer();
			r18.Password = "Password1";
			r18.LastName = "Lineback";
			r18.FirstName = "Erik";
			r18.MiddleInitial = "W";
			r18.ZipCode = 78758;
			r18.City = "Austin";
			r18.State = "TX";
			r18.Street = "1300 Netherland St";
			r18.SSN = 3032449976;
			r18.PhoneNumber = 5125550167;
			r18.Email = "linebacker@gogle.com";
			r18.PopcornPoints = 60;
			r18.BirthDate = new DateTime(12/2/2003);
			r18.CustomerID = 5018;
			db.Customers.AddOrUpdate(r => r.SSN, r18);
			db.SaveChanges();

			Customer r19 = new Customer();
			r19.Password = "aclfest2017";
			r19.LastName = "Lowe";
			r19.FirstName = "Ernest";
			r19.MiddleInitial = "S";
			r19.ZipCode = 78130;
			r19.City = "New Braunfels";
			r19.State = "TX";
			r19.Street = "3201 Pine Drive";
			r19.SSN = 7135344627;
			r19.PhoneNumber = 5125550187;
			r19.Email = "elowe@netscare.net";
			r19.PopcornPoints = 20;
			r19.BirthDate = new DateTime(12/7/1977);
			r19.CustomerID = 5019;
			db.Customers.AddOrUpdate(r => r.SSN, r19);
			db.SaveChanges();

			Customer r20 = new Customer();
			r20.Password = "nothinggood";
			r20.LastName = "Luce";
			r20.FirstName = "Chuck";
			r20.MiddleInitial = "B";
			r20.ZipCode = 79013;
			r20.City = "Cactus";
			r20.State = "TX";
			r20.Street = "2345 Rolling Clouds";
			r20.SSN = 9546983548;
			r20.PhoneNumber = 5125550141;
			r20.Email = "cluce@gogle.com";
			r20.PopcornPoints = 180;
			r20.BirthDate = new DateTime(3/16/1949);
			r20.CustomerID = 5020;
			db.Customers.AddOrUpdate(r => r.SSN, r20);
			db.SaveChanges();

			Customer r21 = new Customer();
			r21.Password = "whatever";
			r21.LastName = "MacLeod";
			r21.FirstName = "Jennifer";
			r21.MiddleInitial = "D.";
			r21.ZipCode = 78654;
			r21.City = "Marble Falls";
			r21.State = "TX";
			r21.Street = "2504 Far West Blvd.";
			r21.SSN = 9074748138;
			r21.PhoneNumber = 5125550185;
			r21.Email = "mackcloud@george.com";
			r21.PopcornPoints = 170;
			r21.BirthDate = new DateTime(2/21/1947);
			r21.CustomerID = 5021;
			db.Customers.AddOrUpdate(r => r.SSN, r21);
			db.SaveChanges();

			Customer r22 = new Customer();
			r22.Password = "whocares";
			r22.LastName = "Markham";
			r22.FirstName = "Elizabeth";
			r22.MiddleInitial = "P.";
			r22.ZipCode = 34741;
			r22.City = "Kissimmee";
			r22.State = "FL";
			r22.Street = "7861 Chevy Chase";
			r22.SSN = 9074579845;
			r22.PhoneNumber = 5125550134;
			r22.Email = "cmartin@beets.com";
			r22.PopcornPoints = 100;
			r22.BirthDate = new DateTime(3/20/1972);
			r22.CustomerID = 5022;
			db.Customers.AddOrUpdate(r => r.SSN, r22);
			db.SaveChanges();

			Customer r23 = new Customer();
			r23.Password = "xcellent";
			r23.LastName = "Martin";
			r23.FirstName = "Clarence";
			r23.MiddleInitial = "A";
			r23.ZipCode = 78709;
			r23.City = "Austin";
			r23.State = "TX";
			r23.Street = "87 Alcedo St.";
			r23.SSN = 9204955201;
			r23.PhoneNumber = 5125550151;
			r23.Email = "clarence@yoho.com";
			r23.PopcornPoints = 130;
			r23.BirthDate = new DateTime(7/19/1992);
			r23.CustomerID = 5023;
			db.Customers.AddOrUpdate(r => r.SSN, r23);
			db.SaveChanges();

			Customer r24 = new Customer();
			r24.Password = "snowsnow";
			r24.LastName = "Martinez";
			r24.FirstName = "Gregory";
			r24.MiddleInitial = "R.";
			r24.ZipCode = 78662;
			r24.City = "Red Rock";
			r24.State = "TX";
			r24.Street = "8295 Sunset Blvd.";
			r24.SSN = 9078746718;
			r24.PhoneNumber = 5125550120;
			r24.Email = "gregmartinez@drdre.com";
			r24.PopcornPoints = 20;
			r24.BirthDate = new DateTime(5/28/1947);
			r24.CustomerID = 5024;
			db.Customers.AddOrUpdate(r => r.SSN, r24);
			db.SaveChanges();

			Customer r25 = new Customer();
			r25.Password = "mydogspot";
			r25.LastName = "Miller";
			r25.FirstName = "Charles";
			r25.MiddleInitial = "R.";
			r25.ZipCode = 78597;
			r25.City = "South Padre Island";
			r25.State = "TX";
			r25.Street = "8962 Main St.";
			r25.SSN = 9077458615;
			r25.PhoneNumber = 5125550198;
			r25.Email = "cmiller@bob.com";
			r25.PopcornPoints = 20;
			r25.BirthDate = new DateTime(10/15/1990);
			r25.CustomerID = 5025;
			db.Customers.AddOrUpdate(r => r.SSN, r25);
			db.SaveChanges();

			Customer r26 = new Customer();
			r26.Password = "spotmydog";
			r26.LastName = "Nelson";
			r26.FirstName = "Kelly";
			r26.MiddleInitial = "T";
			r26.ZipCode = 74340;
			r26.City = "Disney";
			r26.State = "OK";
			r26.Street = "2601 Red River";
			r26.SSN = 9072926966;
			r26.PhoneNumber = 5125550177;
			r26.Email = "knelson@aoll.com";
			r26.PopcornPoints = 110;
			r26.BirthDate = new DateTime(7/13/1971);
			r26.CustomerID = 5026;
			db.Customers.AddOrUpdate(r => r.SSN, r26);
			db.SaveChanges();

			Customer r27 = new Customer();
			r27.Password = "joejoejoe";
			r27.LastName = "Nguyen";
			r27.FirstName = "Joe";
			r27.MiddleInitial = "C";
			r27.ZipCode = 78841;
			r27.City = "Del Rio";
			r27.State = "TX";
			r27.Street = "1249 4th SW St.";
			r27.SSN = 2023125897;
			r27.PhoneNumber = 5125550174;
			r27.Email = "joewin@xfactor.com";
			r27.PopcornPoints = 150;
			r27.BirthDate = new DateTime(3/17/1984);
			r27.CustomerID = 5027;
			db.Customers.AddOrUpdate(r => r.SSN, r27);
			db.SaveChanges();

			Customer r28 = new Customer();
			r28.Password = "billyboy";
			r28.LastName = "O'Reilly";
			r28.FirstName = "Bill";
			r28.MiddleInitial = "T";
			r28.ZipCode = 78746;
			r28.City = "Austin";
			r28.State = "TX";
			r28.Street = "8800 Gringo Drive";
			r28.SSN = 3173450925;
			r28.PhoneNumber = 5125550167;
			r28.Email = "orielly@foxnews.cnn";
			r28.PopcornPoints = 190;
			r28.BirthDate = new DateTime(7/8/1959);
			r28.CustomerID = 5028;
			db.Customers.AddOrUpdate(r => r.SSN, r28);
			db.SaveChanges();

			Customer r29 = new Customer();
			r29.Password = "radgirl";
			r29.LastName = "Radkovich";
			r29.FirstName = "Anka";
			r29.MiddleInitial = "L";
			r29.ZipCode = 78712;
			r29.City = "Austin";
			r29.State = "TX";
			r29.Street = "1300 Elliott Pl";
			r29.SSN = 3022345566;
			r29.PhoneNumber = 5125550151;
			r29.Email = "ankaisrad@gogle.com";
			r29.PopcornPoints = 120;
			r29.BirthDate = new DateTime(5/19/1966);
			r29.CustomerID = 5029;
			db.Customers.AddOrUpdate(r => r.SSN, r29);
			db.SaveChanges();

			Customer r30 = new Customer();
			r30.Password = "meganr34";
			r30.LastName = "Rhodes";
			r30.FirstName = "Megan";
			r30.MiddleInitial = "C.";
			r30.ZipCode = 78705;
			r30.City = "Austin";
			r30.State = "TX";
			r30.Street = "4587 Enfield Rd.";
			r30.SSN = 9073744746;
			r30.PhoneNumber = 5125550133;
			r30.Email = "megrhodes@freserve.co.uk";
			r30.PopcornPoints = 190;
			r30.BirthDate = new DateTime(3/12/1965);
			r30.CustomerID = 5030;
			db.Customers.AddOrUpdate(r => r.SSN, r30);
			db.SaveChanges();

			Customer r31 = new Customer();
			r31.Password = "ricearoni";
			r31.LastName = "Rice";
			r31.FirstName = "Eryn";
			r31.MiddleInitial = "M.";
			r31.ZipCode = 78785;
			r31.City = "Austin";
			r31.State = "TX";
			r31.Street = "3405 Rio Grande";
			r31.SSN = 9073876657;
			r31.PhoneNumber = 5125550196;
			r31.Email = "erynrice@aoll.com";
			r31.PopcornPoints = 190;
			r31.BirthDate = new DateTime(4/28/1975);
			r31.CustomerID = 5031;
			db.Customers.AddOrUpdate(r => r.SSN, r31);
			db.SaveChanges();

			Customer r32 = new Customer();
			r32.Password = "jrod2017";
			r32.LastName = "Rodriguez";
			r32.FirstName = "Jorge";
			r32.MiddleInitial = "";
			r32.ZipCode = 79339;
			r32.City = "Littlefield";
			r32.State = "TX";
			r32.Street = "6788 Cotter Street";
			r32.SSN = 4158904374;
			r32.PhoneNumber = 5125550141;
			r32.Email = "jorge@noclue.com";
			r32.PopcornPoints = 20;
			r32.BirthDate = new DateTime(12/8/1953);
			r32.CustomerID = 5032;
			db.Customers.AddOrUpdate(r => r.SSN, r32);
			db.SaveChanges();

			Customer r33 = new Customer();
			r33.Password = "rogerthat";
			r33.LastName = "Rogers";
			r33.FirstName = "Allen";
			r33.MiddleInitial = "B.";
			r33.ZipCode = 78733;
			r33.City = "Austin";
			r33.State = "TX";
			r33.Street = "4965 Oak Hill";
			r33.SSN = 9078752943;
			r33.PhoneNumber = 5125550189;
			r33.Email = "mrrogers@lovelyday.com";
			r33.PopcornPoints = 100;
			r33.BirthDate = new DateTime(4/22/1973);
			r33.CustomerID = 5033;
			db.Customers.AddOrUpdate(r => r.SSN, r33);
			db.SaveChanges();

			Customer r34 = new Customer();
			r34.Password = "bunnyhop";
			r34.LastName = "Saint-Jean";
			r34.FirstName = "Olivier";
			r34.MiddleInitial = "M";
			r34.ZipCode = 78755;
			r34.City = "Austin";
			r34.State = "TX";
			r34.Street = "255 Toncray Dr.";
			r34.SSN = 3434145678;
			r34.PhoneNumber = 5125550152;
			r34.Email = "stjean@athome.com";
			r34.PopcornPoints = 250;
			r34.BirthDate = new DateTime(2/19/1995);
			r34.CustomerID = 5034;
			db.Customers.AddOrUpdate(r => r.SSN, r34);
			db.SaveChanges();

			Customer r35 = new Customer();
			r35.Password = "penguin12";
			r35.LastName = "Saunders";
			r35.FirstName = "Sarah";
			r35.MiddleInitial = "J.";
			r35.ZipCode = 78701;
			r35.City = "Austin";
			r35.State = "TX";
			r35.Street = "332 Avenue C";
			r35.SSN = 9073497810;
			r35.PhoneNumber = 5125550146;
			r35.Email = "saunders@pen.com";
			r35.PopcornPoints = 40;
			r35.BirthDate = new DateTime(2/19/1978);
			r35.CustomerID = 5035;
			db.Customers.AddOrUpdate(r => r.SSN, r35);
			db.SaveChanges();

			Customer r36 = new Customer();
			r36.Password = "alaskaboy";
			r36.LastName = "Sewell";
			r36.FirstName = "William";
			r36.MiddleInitial = "T.";
			r36.ZipCode = 79953;
			r36.City = "El Paso";
			r36.State = "TX";
			r36.Street = "2365 51st St.";
			r36.SSN = 9074510084;
			r36.PhoneNumber = 5125550192;
			r36.Email = "willsheff@email.com";
			r36.PopcornPoints = 200;
			r36.BirthDate = new DateTime(12/23/2004);
			r36.CustomerID = 5036;
			db.Customers.AddOrUpdate(r => r.SSN, r36);
			db.SaveChanges();

			Customer r37 = new Customer();
			r37.Password = "martin1234";
			r37.LastName = "Sheffield";
			r37.FirstName = "Martin";
			r37.MiddleInitial = "J.";
			r37.ZipCode = 79718;
			r37.City = "Balmorhea";
			r37.State = "TX";
			r37.Street = "3886 Avenue A";
			r37.SSN = 9075479167;
			r37.PhoneNumber = 5125550131;
			r37.Email = "sheffiled@gogle.com";
			r37.PopcornPoints = 130;
			r37.BirthDate = new DateTime(5/8/1960);
			r37.CustomerID = 5037;
			db.Customers.AddOrUpdate(r => r.SSN, r37);
			db.SaveChanges();

			Customer r38 = new Customer();
			r38.Password = "smitty444";
			r38.LastName = "Smith";
			r38.FirstName = "John";
			r38.MiddleInitial = "A";
			r38.ZipCode = 78760;
			r38.City = "Austin";
			r38.State = "TX";
			r38.Street = "23 Hidden Forge Dr.";
			r38.SSN = 2838321888;
			r38.PhoneNumber = 5125550190;
			r38.Email = "johnsmith187@aoll.com";
			r38.PopcornPoints = 130;
			r38.BirthDate = new DateTime(6/25/1955);
			r38.CustomerID = 5038;
			db.Customers.AddOrUpdate(r => r.SSN, r38);
			db.SaveChanges();

			Customer r39 = new Customer();
			r39.Password = "dustydusty";
			r39.LastName = "Stroud";
			r39.FirstName = "Dustin";
			r39.MiddleInitial = "P";
			r39.ZipCode = 78734;
			r39.City = "Austin";
			r39.State = "TX";
			r39.Street = "1212 Rita Rd";
			r39.SSN = 2172346667;
			r39.PhoneNumber = 5125550157;
			r39.Email = "dustroud@mail.com";
			r39.PopcornPoints = 90;
			r39.BirthDate = new DateTime(7/26/1967);
			r39.CustomerID = 5039;
			db.Customers.AddOrUpdate(r => r.SSN, r39);
			db.SaveChanges();

			Customer r40 = new Customer();
			r40.Password = "stewball";
			r40.LastName = "Stuart";
			r40.FirstName = "Eric";
			r40.MiddleInitial = "D.";
			r40.ZipCode = 78640;
			r40.City = "Kyle";
			r40.State = "TX";
			r40.Street = "5576 Toro Ring";
			r40.SSN = 9078178335;
			r40.PhoneNumber = 5125550191;
			r40.Email = "estuart@anchor.net";
			r40.PopcornPoints = 170;
			r40.BirthDate = new DateTime(12/4/1947);
			r40.CustomerID = 5040;
			db.Customers.AddOrUpdate(r => r.SSN, r40);
			db.SaveChanges();

			Customer r41 = new Customer();
			r41.Password = "slowwind";
			r41.LastName = "Stump";
			r41.FirstName = "Peter";
			r41.MiddleInitial = "L";
			r41.ZipCode = 19123;
			r41.City = "Philadelphia";
			r41.State = "PA";
			r41.Street = "1300 Kellen Circle";
			r41.SSN = 2084560903;
			r41.PhoneNumber = 5125550136;
			r41.Email = "peterstump@noclue.com";
			r41.PopcornPoints = 50;
			r41.BirthDate = new DateTime(7/10/1974);
			r41.CustomerID = 5041;
			db.Customers.AddOrUpdate(r => r.SSN, r41);
			db.SaveChanges();

			Customer r42 = new Customer();
			r42.Password = "tanner5454";
			r42.LastName = "Tanner";
			r42.FirstName = "Jeremy";
			r42.MiddleInitial = "S.";
			r42.ZipCode = 78747;
			r42.City = "Austin";
			r42.State = "TX";
			r42.Street = "4347 Almstead";
			r42.SSN = 9074590929;
			r42.PhoneNumber = 5125550170;
			r42.Email = "jtanner@mustang.net";
			r42.PopcornPoints = 190;
			r42.BirthDate = new DateTime(1/11/1944);
			r42.CustomerID = 5042;
			db.Customers.AddOrUpdate(r => r.SSN, r42);
			db.SaveChanges();

			Customer r43 = new Customer();
			r43.Password = "allyrally";
			r43.LastName = "Taylor";
			r43.FirstName = "Allison";
			r43.MiddleInitial = "R.";
			r43.ZipCode = 78712;
			r43.City = "Austin";
			r43.State = "TX";
			r43.Street = "467 Nueces St.";
			r43.SSN = 9074748452;
			r43.PhoneNumber = 5125550160;
			r43.Email = "taylordjay@aoll.com";
			r43.PopcornPoints = 110;
			r43.BirthDate = new DateTime(11/14/1990);
			r43.CustomerID = 5043;
			db.Customers.AddOrUpdate(r => r.SSN, r43);
			db.SaveChanges();

			Customer r44 = new Customer();
			r44.Password = "taylorbaylor";
			r44.LastName = "Taylor";
			r44.FirstName = "Rachel";
			r44.MiddleInitial = "K.";
			r44.ZipCode = 78758;
			r44.City = "Austin";
			r44.State = "TX";
			r44.Street = "345 Longview Dr.";
			r44.SSN = 9074907631;
			r44.PhoneNumber = 5125550127;
			r44.Email = "rtaylor@gogle.com";
			r44.PopcornPoints = 160;
			r44.BirthDate = new DateTime(1/18/1976);
			r44.CustomerID = 5044;
			db.Customers.AddOrUpdate(r => r.SSN, r44);
			db.SaveChanges();

			Customer r45 = new Customer();
			r45.Password = "teeoff22";
			r45.LastName = "Tee";
			r45.FirstName = "Frank";
			r45.MiddleInitial = "J";
			r45.ZipCode = 78729;
			r45.City = "Austin";
			r45.State = "TX";
			r45.Street = "5590 Lavell Dr";
			r45.SSN = 2138765543;
			r45.PhoneNumber = 5125550161;
			r45.Email = "teefrank@noclue.com";
			r45.PopcornPoints = 70;
			r45.BirthDate = new DateTime(9/6/1998);
			r45.CustomerID = 5045;
			db.Customers.AddOrUpdate(r => r.SSN, r45);
			db.SaveChanges();

			Customer r46 = new Customer();
			r46.Password = "tucksack1";
			r46.LastName = "Tucker";
			r46.FirstName = "Clent";
			r46.MiddleInitial = "J";
			r46.ZipCode = 78665;
			r46.City = "Round Rock";
			r46.State = "TX";
			r46.Street = "312 Main St.";
			r46.SSN = 9038471154;
			r46.PhoneNumber = 5125550106;
			r46.Email = "ctucker@alphabet.co.uk";
			r46.PopcornPoints = 150;
			r46.BirthDate = new DateTime(2/25/1943);
			r46.CustomerID = 5046;
			db.Customers.AddOrUpdate(r => r.SSN, r46);
			db.SaveChanges();

			Customer r47 = new Customer();
			r47.Password = "meow88";
			r47.LastName = "Velasco";
			r47.FirstName = "Allen";
			r47.MiddleInitial = "G";
			r47.ZipCode = 78613;
			r47.City = "Cedar Park";
			r47.State = "TX";
			r47.Street = "679 W. 4th";
			r47.SSN = 3103985638;
			r47.PhoneNumber = 5125550170;
			r47.Email = "avelasco@yoho.com";
			r47.PopcornPoints = 0;
			r47.BirthDate = new DateTime(9/10/1985);
			r47.CustomerID = 5047;
			db.Customers.AddOrUpdate(r => r.SSN, r47);
			db.SaveChanges();

			Customer r48 = new Customer();
			r48.Password = "vinovino";
			r48.LastName = "Vino";
			r48.FirstName = "Janet";
			r48.MiddleInitial = "E";
			r48.ZipCode = 78644;
			r48.City = "Lockhart";
			r48.State = "TX";
			r48.Street = "189 Grape Road";
			r48.SSN = 8175643832;
			r48.PhoneNumber = 5125550128;
			r48.Email = "vinovino@grapes.com";
			r48.PopcornPoints = 160;
			r48.BirthDate = new DateTime(2/7/1985);
			r48.CustomerID = 5048;
			db.Customers.AddOrUpdate(r => r.SSN, r48);
			db.SaveChanges();

			Customer r49 = new Customer();
			r49.Password = "gowest";
			r49.LastName = "West";
			r49.FirstName = "Jake";
			r49.MiddleInitial = "T";
			r49.ZipCode = 78705;
			r49.City = "Austin";
			r49.State = "TX";
			r49.Street = "RR 3287";
			r49.SSN = 5938475244;
			r49.PhoneNumber = 2025550170;
			r49.Email = "westj@pioneer.net";
			r49.PopcornPoints = 70;
			r49.BirthDate = new DateTime(1/9/1976);
			r49.CustomerID = 5049;
			db.Customers.AddOrUpdate(r => r.SSN, r49);
			db.SaveChanges();

			Customer r50 = new Customer();
			r50.Password = "louielouie";
			r50.LastName = "Winthorpe";
			r50.FirstName = "Louis";
			r50.MiddleInitial = "L";
			r50.ZipCode = 78747;
			r50.City = "Austin";
			r50.State = "TX";
			r50.Street = "2500 Padre Blvd";
			r50.SSN = 2105650098;
			r50.PhoneNumber = 2025550141;
			r50.Email = "winner@hootmail.com";
			r50.PopcornPoints = 150;
			r50.BirthDate = new DateTime(4/19/1953);
			r50.CustomerID = 5050;
			db.Customers.AddOrUpdate(r => r.SSN, r50);
			db.SaveChanges();

			Customer r51 = new Customer();
			r51.Password = "woodyman1";
			r51.LastName = "Wood";
			r51.FirstName = "Reagan";
			r51.MiddleInitial = "B.";
			r51.ZipCode = 78753;
			r51.City = "Austin";
			r51.State = "TX";
			r51.Street = "447 Westlake Dr.";
			r51.SSN = 9074545242;
			r51.PhoneNumber = 2025550128;
			r51.Email = "rwood@voyager.net";
			r51.PopcornPoints = 20;
			r51.BirthDate = new DateTime(12/28/2002);
			r51.CustomerID = 5051;
			db.Customers.AddOrUpdate(r => r.SSN, r51);
			db.SaveChanges();

		}
	}
}
