# DEVLOG

2023/09/06:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Database Planing; <br>
&nbsp;&nbsp;&nbsp;&nbsp;- ERM First Draft;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Create DB in SQL first Draft;<br>
<br>
2023/09/07:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Continued work on DB;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Started Coding Login Screen;<br>
<br>
2023/09/08:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Complete DB redesign;<br>
<br>
2023/09/12:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Login screen complete (non functional);<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Basic main menu layout;<br>
<br>
2023/09/13:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Login functional with unencrypted passwords;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Created EF Model for users table;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Created "My Account" page basic layout;<br>
<br>
2023/09/13:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Altered DB connection string to dinamically fetch DB path for connection string;<br>
<br>
2023/09/19:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Fixed bug that caused previous update to connection string to stop working when project was reloaded;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Fixed bug in custom text and password box data bindings;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Created EF models for remaining DB tables;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added way to store currently logged in username;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added "Remember Me" and "Show Password" checkboxes to login screen;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added functionality for "Remember Me" checkbox to read and write username to JSON file;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added "Show Password" functionality;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added data bindings to "My Account" page;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added button to rever changes in "My Account";<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Added password encryption;<br>
<br>
2023/09/20:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Found bug when loading data from contacts table, commented out bugged code to test rest of app;<br>
<br>
2023/09/21:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Consolidated data context files into one for simplicity and bug fixes;<br>

-- Project Deadline Reached -- <br>
The state of the project as of 2023/09/21 is what was submited as my school project.
Further development past this point will be done in my free time.
----

TODO:<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Fix EF null reference bug when calling contacts table (CRITICAL);<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Add CRUD functionality to employee and customer accounts;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Create Store management page;<br>
&nbsp;&nbsp;&nbsp;&nbsp;- Create Sale management page;<br>
