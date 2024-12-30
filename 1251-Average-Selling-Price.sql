/* Write your PL/SQL query statement below */

SELECT 
    prices.product_id, 
    COALESCE(ROUND(SUM(price * units) / SUM(units), 2), 0) AS average_price
FROM 
    prices 
LEFT JOIN 
    UnitsSold 
ON 
    prices.product_id = UnitsSold.product_id 
    AND purchase_date BETWEEN prices.start_date AND prices.end_date
GROUP BY prices.product_id;