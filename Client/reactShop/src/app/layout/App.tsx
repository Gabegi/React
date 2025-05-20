import ProductList from "../../features/products/ProductList";
import { defaultProducts } from "../models/defaultProducts";

function App() {
  return (
    <>
      <ProductList products={defaultProducts} />
    </>
  );
}

export default App;
