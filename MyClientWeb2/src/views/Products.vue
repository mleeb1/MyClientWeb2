<template>
  <div class="products">
    <h1>This is a {{ appName }}</h1>
    <button @click="getProducts()">
      Get Products
    </button>
    <h3>{{ error }}</h3>
    <h3>Products ...</h3>
    <ul>
      <li
        v-for="product in products"
        :key="product"
      >
        {{ product.name }}
      </li>
    </ul>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  data () {
    return {
      appName: 'Products page',
      error: '',
      isBusy: false,
      products: []
    }
  },
  methods: {
    getProducts: function () {
      this.error = ''
      this.isBusy = true
      axios.get('http://localhost:8081/api/products')
        .then((response) => {
          this.isBusy = false
          this.products = response.data.value
        }, (error) => {
          this.isBusy = false
          this.error = error
        })
    }
  },
  mounted () {
  },
  computed: {
  }
}
</script>
