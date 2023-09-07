--DB will be created directly in VS2022, sql file to serve as reference only

CREATE DATABASE IF NOT EXISTS db_store;

USE db_store;

CREATE TABLE IF NOT EXISTS t_countries (
    id_country INT PRIMARY KEY,
    name_country VARCHAR(100) NOT NULL,
    phone_prefix VARCHAR(3) NOT NULL,
    iso2 CHAR(2) NOT NULL,
    iso3 CHAR(3) NOT NULL
);

CREATE TABLE IF NOT EXISTS t_adresses (
    id INT PRIMARY KEY AUTOINCREMENT,
    line1 VARCHAR(100) NOT NULL,
    line2 VARCHAR(100),
    city VARCHAR(50),
    postcode VARCHAR(10) NOT NULL,
    id_country INT NOT NULL
);

CREATE TABLE IF NOT EXISTS t_clients (
    id_client CHAR(8) PRIMARY KEY,
    fname_client VARCHAR(50) NOT NULL,
    lname_client VARCHAR(50) NOT NULL,
    is_active BIT NOT NULL,
    loyalty_points INT NOT NULL CHECK (loyalty_points >= 0),
    dob_client DATE,
    tax_id_client VARCHAR(15) NOT NULL,
    email_client VARCHAR(320),
    phone_client VARCHAR(15),
    landline_client VARCHAR(15),
    id_adress INT NOT NULL,
    CONSTRAINT ContactNotNull
        CHECK (
            (email_client IS NOT NULL) OR
            (phone_client IS NOT NULL) OR
            (landline_client IS NOT NULL)
        )
);

-- Customer ID autoincrement with prefix 'C'
ALTER TABLE t_clients
MODIFY COLUMN id_client CHAR(8) GENERATED ALWAYS AS (
    CONCAT('C', LPAD(AUTO_INCREMENT + 1000000, 7, '0'))
) STORED;

CREATE TABLE IF NOT EXISTS t_employees (
    id_employee CHAR(8) PRIMARY KEY,
    fname_employee VARCHAR(50) NOT NULL,
    lname_employee VARCHAR(50) NOT NULL,
    is_active BIT NOT NULL,
    login_employee VARCHAR(8) NOT NULL,
    dob_employee DATE NOT NULL,
    tax_id_employee VARCHAR(15) NOT NULL,
    email_employee VARCHAR(320),
    phone_employee VARCHAR(15),
    landline_employee VARCHAR(15),
    date_hired DATE NOT NULL,
    date_fired DATE,
    salary_monthly DECIMAL(10,2) NOT NULL,
    id_adress INT NOT NULL,
    is_manager BIT NOT NULL,
    is_fulltime BIT NOT NULL,
    id_store CHAR(4) NOT NULL,
    CONSTRAINT ContactNotNull
        CHECK (
            (email_employee IS NOT NULL) OR
            (phone_employee IS NOT NULL) OR
            (landline_employee IS NOT NULL)
        ),
    CONSTRAINT StorePrefix CHECK (
        (id_store LIKE 'S%' AND id_store >= 'S001' AND id_store <= 'S999') OR
        (id_store LIKE 'HQ%' AND id_store >= 'HQ01' AND id_store <= 'HQ99')
        )
);

-- Employee ID autoincrement with prefix 'E'
ALTER TABLE t_employees
MODIFY COLUMN id_employee CHAR(8) GENERATED ALWAYS AS (
    CONCAT('E', LPAD(AUTO_INCREMENT + 1000000, 7, '0'))
) STORED;

-- Store ID autoincrement to be implemented later
CREATE TABLE IF NOT EXISTS t_stores(
    id_store CHAR(4) PRIMARY KEY,
    name_store VARCHAR(50) NOT NULL,
    is_active BIT NOT NULL,
    date_open DATE NOT NULL,
    date_close DATE,
    id_gmanager CHAR(8) NOT NULL,
    tax_id_store VARCHAR(15) NOT NULL,
    landline_store VARCHAR(15),
    email_store VARCHAR(320),
    CONSTRAINT StorePrefix CHECK (
        (id_store LIKE 'S%' AND id_store >= 'S001' AND id_store <= 'S999') OR
        (id_store LIKE 'HQ%' AND id_store >= 'HQ01' AND id_store <= 'HQ99')
    ),
    CONSTRAINT GM_ID CHECK (id_gmanager LIKE 'E%' AND LENGTH(id_gmanager) = 8)
);

CREATE TABLE IF NOT EXISTS t_suppliers (
    id_supplier CHAR(6) PRIMARY KEY,
    name_supplier VARCHAR(50) NOT NULL,
    is_active BIT NOT NULL,
    date_hired DATE NOT NULL,
    date_fired DATE,
    tax_id_supplier VARCHAR(15) NOT NULL,
    landline_supplier VARCHAR(15) NOT NULL,
    email_supplier VARCHAR(320)  NOT NULL
);

-- Supplier ID autoincrement with prefix 'SP'
ALTER TABLE t_suppliers
MODIFY COLUMN id_supplier CHAR(6) GENERATED ALWAYS AS (
    CONCAT('SP', LPAD(AUTO_INCREMENT, 4, '0'))
);

CREATE TABLE IF NOT EXISTS t_products (
    id_product CHAR(8) PRIMARY KEY,
    name_product VARCHAR(50) NOT NULL,
    unit_type VARCHAR(2) NOT NULL,
    unit_price DECIMAL(10,2) NOT NULL,
    pdescription TEXT,
    tax_percent INT NOT NULL CHECK (tax_percent >= 0 AND tax_percent <= 100),
    is_active BIT NOT NULL,
    stock DECIMAL (10,2) NOT NULL CHECK (stock >= 0)
);

-- Product ID autoincrement with prefix 'P'
ALTER TABLE t_products
MODIFY COLUMN id_product CHAR(8) GENERATED ALWAYS AS (
    CONCAT('P', LPAD(AUTO_INCREMENT + 1000000, 7, '0'))
);

-- Sale ID autoincrement to be implemented later
CREATE TABLE IF NOT EXISTS t_sales (
    id_sale CHAR(20) PRIMARY KEY,
    date_sale DATETIME NOT NULL,
    id_client CHAR(8) NOT NULL,
    id_employee CHAR(8) NOT NULL,
    CONSTRAINT ClientIDFormat
        CHECK (
            (id_client LIKE 'C%' AND
            LENGTH(id_client) = 8 AND
            SUBSTRING(id_client, 2) BETWEEN '0000001' AND '9999999')
        ),
    CONSTRAINT EmployeeIDFormat
        CHECK (
            (id_employee LIKE 'E%' AND
            LENGTH(id_employee) = 8 AND
            SUBSTRING(id_employee, 2) BETWEEN '0000001' AND '9999999')
        )
);

CREATE TABLE IF NOT EXISTS t_purchases (
    id_purchase CHAR(20) PRIMARY KEY,
    date_purchase DATETIME NOT NULL,
    id_supplier CHAR(6) NOT NULL,
    id_store CHAR(4) NOT NULL,
    CONSTRAINT SupplierIDFormat
        CHECK (
            (id_supplier LIKE 'SP' AND
            LENGTH(id_supplier) = 6 AND
            SUBSTRING(id_supplier, 3) BETWEEN '0001' AND '9999')
        )
);

CREATE TABLE IF NOT EXISTS t_supplier_items(
    id INT PRIMARY KEY AUTOINCREMENT,
    max_order DECIMAL(10,2) NOT NULL CHECK (max_order >= 0),
    unit_cost DECIMAL(10,2) NOT NULL CHECK (unit_cost >= 0),
    id_supplier CHAR(6) NOT NULL,
    id_product CHAR(8) NOT NULL,
    CONSTRAINT SupplierIDFormat
        CHECK (
            (id_supplier LIKE 'SP%' AND
            LENGTH(id_supplier) = 8 AND
            SUBSTRING(id_supplier, 3) BETWEEN '000001' AND '999999')
        ),
    CONSTRAINT ProductIDFormat
        CHECK (
            (id_product LIKE 'P%' AND
            LENGTH(id_product) = 9 AND
            SUBSTRING(id_product, 2) BETWEEN '0000001' AND '9999999')
        )
);

CREATE TABLE IF NOT EXISTS t_sorder_items (
    id INT PRIMARY KEY AUTOINCREMENT,
    quantity DECIMAL(10,2) NOT NULL,
    discount_percent INT NOT NULL CHECK (discount_percent >= 0 AND discount_percent <= 100),
    id_sale CHAR(20) NOT NULL,
    id_product CHAR(8),
    CONSTRAINT SaleIDFormat
        CHECK (
            (id_sale LIKE 'F%'
            AND SUBSTRING(id_sale, 2, 4) BETWEEN '1970' AND '9999'
            AND LENGTH(id_sale) = 20
            AND SUBSTRING(id_sale, 6) REGEXP '^[0-9]{14}$')
        ),
    CONSTRAINT ProductIDFormat
        CHECK (
            (id_product LIKE 'P%' AND
            LENGTH(id_product) = 9 AND
            SUBSTRING(id_product, 2) BETWEEN '0000001' AND '9999999')
        )
);

CREATE TABLE IF NOT EXISTS t_porder_items (
    id INT PRIMARY KEY AUTOINCREMENT,
    quantity DECIMAL(10,2) NOT NULL,
    unit_cost DECIMAL(10,2) NOT NULL CHECK (unit_cost >= 0),
    id_product CHAR(8),
    id_purchase CHAR(20),
    CONSTRAINT ProductIDFormat
        CHECK (
            (id_product LIKE 'P%' AND
            LENGTH(id_product) = 9 AND
            SUBSTRING(id_product, 2) BETWEEN '0000001' AND '9999999')
        ),
    CONSTRAINT PurchaseIDFormat
        CHECK (
            (id_purchase LIKE 'PO%'
            AND SUBSTRING(id_purchase, 3, 4) BETWEEN '1970' AND '9999'
            AND LENGTH(id_purchase) = 15
            AND SUBSTRING(id_purchase, 7) REGEXP '^[0-9]{13}$')
        )
);
