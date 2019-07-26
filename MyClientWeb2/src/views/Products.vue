<template>
  <div class="products">
    <h1>This is a {{ appName }}</h1>
  </div>
</template>

<script>
export default {
  data () {
    return {
      appName: 'Products page',
      error: '',
      isBusy: false
    }
  },
  methods: {
  },
  mounted () {
    // TODO: Call the API
    this.error = ''
    this.isBusy = true
  },
  computed: {
  }
}
</script>
