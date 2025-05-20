import ProductList from "./features/products/ProductList.tsx";
import type { defaultProducts } from "../models/defaultProducts";

function App() {
  return (
    <>
      {/* <Navbar /> */}
      <ProductList products={defaultProducts} />
    </>
  );
}

export default App;
