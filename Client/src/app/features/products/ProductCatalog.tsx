export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch("https://localhost:7010/api/Products/")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);

    return (
    <div>
      <ProductList products={products} />
    </div>
}
