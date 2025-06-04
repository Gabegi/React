import { useEffect, useState } from "react";
import type { Product } from "../../models/product";
import ProductList from "./ProductList";
import Navbar from "../../layout/Navbar";
import { Container } from "@mui/material";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch("https://localhost:7020/api/Product")
      .then((response) => {
        if (!response.ok) {
          throw new Error("Failed to fetch products");
        }
        return response.json();
      })
      .then((data) => setProducts(data)) // loading succesfully
      .catch((error) => console.error(error))
      .finally(() => setLoading(false)); // loading unsuccessfully
  }, []);

  return (
    <>
      <Navbar />
      <Container sx={{ marginTop: "80px" }}>
        {loading ? (
          <p>Error loading products...</p>
        ) : (
          <ProductList products={products} />
        )}
      </Container>
    </>
  );
}
