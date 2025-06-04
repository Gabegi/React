import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../features/home/HomePage";
import Catalog from "../features/products/ProductCatalog";

export const router = createBrowserRouter([
  {
    path: "/", // root Route
    element: <App />, // components
    children: [
      { path: "", element: <HomePage /> },
      { path: "/catalog", element: <Catalog /> },
      { path: "/catalog/:id", element: <ProductDetails /> },
      { path: "/about", element: <AboutPage /> },
      { path: "/contact", element: <ContactPage /> },
    ],
  },
]);
