export default function Home() {
    return (
        <section>
            <div>
                <h1>This is private, very private</h1>
                <div>
                    <p>Hope Ill see you again soon</p>
                </div>
                <a
          href="/"
          className="group rounded-lg border border-transparent px-5 py-4 transition-colors hover:border-gray-300 hover:bg-gray-100 hover:dark:border-neutral-700 hover:dark:bg-neutral-800/30"
          rel="noopener noreferrer"
        >
          <h2 className={`mb-3 text-2xl font-semibold`}>
            Home{' '}
            <span className="inline-block transition-transform group-hover:translate-x-1 motion-reduce:transform-none">
              -&gt;
            </span>
          </h2>
          <p className={`m-0 max-w-[30ch] text-sm opacity-50`}>
            Just go back from whence you came
          </p>
        </a>
            </div>
        </section>
    )
}