import ProductList from "../../features/products/ProductList";
import { defaultProducts } from "../models/defaultProducts";
import Navbar from "./Navbar";

function App() {
  return (
    <>
      <Navbar />
      <ProductList products={defaultProducts} />
    </>
  );
}

export default App;
