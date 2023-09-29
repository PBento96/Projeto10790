# DEVLOG

2023/09/06:
    - Database Planing;
    - ERM First Draft;
    - Create DB in SQL first Draft;

2023/09/07:
    - Continued work on DB;
    - Started Coding Login Screen;

2023/09/08:
    - Complete DB redesign;

2023/09/12:
    - Login screen complete (non functional);
    - Basic main menu layout;

2023/09/13:
    - Login functional with unencrypted passwords;
    - Created EF Model for users table;
    - Created "My Account" page basic layout;

2023/09/13:
    - Altered DB connection string to dinamically fetch DB path for connection string;

2023/09/19:
    - Fixed bug that caused previous update to connection string to stop working when project was reloaded;
    - Fixed bug in custom text and password box data bindings;
    - Created EF models for remaining DB tables;
    - Added way to store currently logged in username;
    - Added "Remember Me" and "Show Password" checkboxes to login screen;
    - Added functionality for "Remember Me" checkbox to read and write username to JSON file;
    - Added "Show Password" functionality;
    - Added data bindings to "My Account" page;
    - Added button to rever changes in "My Account";
    - Added password encryption;

2023/09/20:
    - Found bug when loading data from contacts table, commented out bugged code to test rest of app;

2023/09/21:
    - Consolidated data context files into one for simplicity and bug fixes;

-- Project Deadline Reached --
The state of the project as of 2023/09/21 is what was submited as my school project.
Further development past this point will be done in my free time.
----

TODO:
    - Fix EF null reference bug when calling contacts table (CRITICAL);
    - Add CRUD functionality to employee and customer accounts;
    - Create Store management page;
    - Create Sale management page;
