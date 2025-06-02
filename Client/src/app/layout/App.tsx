import { Container } from "@mui/material";
import ProductList from "../features/products/ProductList";
import Navbar from "./Navbar";

function App() {
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
