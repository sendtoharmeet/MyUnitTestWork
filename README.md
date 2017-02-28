# MyUnitTestWork
Start of repository
This is an simple API project with API testing UI.
A customer will send a ProcessOrder request with valid parameters 
If the input object will be correct it will save in database
If any validation fails, it will return error code 400 and with errorResponse containing all validation failure message.

API Tester is avaialable to test API, or you can just make ajax call to test API as follows: 

var obj = {
FirstName:"TestfirstName",  
LastName:"TestLastName",  
Address:"India chandigarh", 
City:"Chandigarh", 
State :"Punjab",
Zip :"13452",
Phone :646456,
Email :"sendtoharmeet@yahoo.com",
CardNumber :5345345,
CardExpiryMonth :11,
CardExpiryYear :2017,
CardSecurityCode :123,
ProductId :33,
ProductPrice :24334
};

$.ajax({
 type: "POST",
 url: "api/ProcessOrder",
 data: obj,
 success: function(msg) {
 	alert('Saved');
 },
 error: function(a,b,c) {
	alert(a.responseText);
 }
});
