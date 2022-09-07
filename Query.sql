select ProductName, CategoryName
from Product
         left join ProductInfo PI on Product.ProductId = PI.ProductId
         left join Category C on PI.CategoryId = C.CategoryId;