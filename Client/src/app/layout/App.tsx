import { Container } from "@mui/material";
import ProductList from "../features/products/ProductList";
import Navbar from "./Navbar";
import { Product } from "../models/product";
import { useEffect, useState } from "react";

function App() {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch("https://localhost:7004/api/Product")
      .then((response) => {
        if (!response.ok) {
          throw new Error("Failed to fetch products");
        }
        return response.json();
      })
      .then((data) => setProducts(data))
      .catch((error) => console.error(error))
      .finally(() => setLoading(false));
  }, []);

  return (
    <>
      <Navbar />
      <Container sx={{ marginTop: "80px" }}>
        <ProductList products={defaultProducts} />
      </Container>
    </>
  );
}

export default App;
